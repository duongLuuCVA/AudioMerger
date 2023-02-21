using AudioMerger;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Merger
{
    private readonly HomeUI homeUI;

    private CancellationTokenSource tokenSource;
    private bool isStop;

    public bool IsOutputToMpeg { get; set; }
    public bool IsStop
    {
        get => isStop;
        set
        {
            isStop = value;
            if (isStop)
                tokenSource?.Cancel();
        }
    }

    public Merger(HomeUI homeUI)
    {
        this.homeUI = homeUI;
    }

    public async void Combine(string[] inputFiles, string outputFile)
    {
        IsStop = false;

        tokenSource = new CancellationTokenSource();
        var token = tokenSource.Token;

        try
        {
            if (inputFiles.Length == 0)
            {
                throw new Exception("Input files empty!");
            }


            CreateParentIfNotExisted(outputFile);
            
            if (IsOutputToMpeg)
            {
                await Task.Run(() => CombineMp3(inputFiles, outputFile, token), token);
            }
            else
            {
                await Task.Run(() => CombineWav(inputFiles, outputFile, token), token);
            }
        }
        catch (OperationCanceledException)
        {
            UpdateUIMessage("Canceled!", "");
        }
        catch (Exception e)
        {
            UpdateUIMessage("Failed!", e.Message);
            System.Diagnostics.Debug.WriteLine(e.ToString() + " " + e.Message);
        }
        finally
        {
            tokenSource?.Dispose();
            tokenSource = null;
        }
    }

    private void CreateParentIfNotExisted(string filePath)
    {
        var directoryInfo = Directory.GetParent(filePath);
        if (directoryInfo == null) throw new InvalidDataException($"Invalid Path: {filePath}");
        if (directoryInfo.Exists) return;
        directoryInfo.Create();
    }
    
    private void CombineMp3(string[] inputFiles, string outputFile, CancellationToken cancellationToken)
    {
        using (Stream output = File.OpenWrite(outputFile))
        {
            homeUI.ProgressBar.Maximum = inputFiles.Length - 1;
            for (int i = 0; i < inputFiles.Length && !IsStop; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }

                string file = inputFiles[i];
                if (!file.EndsWith(".mp3"))
                {
                    throw new Exception("Mp3 output only support merging .mp3 files!");
                }

                UpdateUi(i, inputFiles.Length + 1, FileUlti.GetFileName(file));
                using (Mp3FileReader reader = new Mp3FileReader(file))
                {
                    if ((output.Position == 0) && (reader.Id3v2Tag != null))
                    {
                        output.Write(reader.Id3v2Tag.RawData, 0, reader.Id3v2Tag.RawData.Length);
                    }
                    Mp3Frame frame;
                    while ((frame = reader.ReadNextFrame()) != null && !IsStop)
                    {
                        output.Write(frame.RawData, 0, frame.RawData.Length);
                        if (cancellationToken.IsCancellationRequested)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                        }
                    }
                }
            }

        }
        UpdateUIMessage("Merge complete!", "");
        homeUI.ProgressBar.Value = homeUI.ProgressBar.Maximum;
        homeUI.BtnFinish.Enabled = true;
        homeUI.BtnMerge.Text = "Merge";
    }

    private void CombineWav(string[] inputFiles, string outputFile, CancellationToken cancellationToken)
    {
        var readers = new AudioFileReader[inputFiles.Length];
        try
        {
            int length = 0;
            int lengthPassed = 0;
            var sampleProviders = new ISampleProvider[inputFiles.Length];
            for (int i = 0; i < inputFiles.Length && !IsStop; i++)
            {
                UpdateUi(i, inputFiles.Length + 1, inputFiles[i]);
                AudioFileReader reader = new AudioFileReader(inputFiles[i]);
                readers[i] = reader;
                length += (int)reader.Length;
                var outFormat = new WaveFormat(16000, 2);
                using (var resampler = new MediaFoundationResampler(reader, outFormat))
                {
                    // resampler.ResamplerQuality = 60;
                    sampleProviders[i] = resampler.ToSampleProvider();
                }
            }

            if (cancellationToken.IsCancellationRequested)
            {
                cancellationToken.ThrowIfCancellationRequested();
            }

            UpdateUIMessage("Merging files!", "");

            var mixer = new ConcatenatingSampleProvider(sampleProviders);
            var sourceProvider = new SampleToWaveProvider16(mixer);
            using (var writer = new WaveFileWriter(outputFile, sourceProvider.WaveFormat))
            {
                var buffer = new byte[sourceProvider.WaveFormat.AverageBytesPerSecond * 4];
                while (true)
                {

                    int bytesRead = sourceProvider.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        // end of source provider
                        break;
                    }

                    if (cancellationToken.IsCancellationRequested)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                    }
                    lengthPassed += bytesRead;
                    UpdateUi(lengthPassed, length, "");
                    UpdateUIMessage("Merging files!", "");

                    // Write will throw exception if WAV file becomes too large
                    writer.Write(buffer, 0, bytesRead);
                }
            }
            UpdateUIMessage("Merge complete!", "");
            homeUI.ProgressBar.Value = homeUI.ProgressBar.Maximum;
            homeUI.BtnFinish.Enabled = true;
            homeUI.BtnMerge.Text = "Merge";
        }
        catch (Exception e)
        {
            homeUI.ProgressBar.Value = 0;
            UpdateUIMessage("Failed", e.Message);
            System.Diagnostics.Debug.WriteLine(e.ToString());
        }
        finally
        {
            for (int i = 0; i < inputFiles.Length; i++)
            {
                try
                {
                    readers[i]?.Close();
                }
                catch (IOException e)
                {
                    System.Diagnostics.Debug.Fail(e.ToString());
                }
            }
        }
    }

    private void UpdateUi(int fileIndex, int totalFile, string fileName)
    {
        homeUI.ProgressBar.Maximum = totalFile;
        homeUI.ProgressBar.Value = fileIndex;
        UpdateUIMessage("Processing: " + fileName, $"{fileIndex + 1}/{totalFile}");
    }

    private void UpdateUIMessage(string leftMessage, string rightMessage)
    {
        homeUI.LblInfoLeft.Text = leftMessage;
        homeUI.LblInfoRight.Text = rightMessage;
    }
}
