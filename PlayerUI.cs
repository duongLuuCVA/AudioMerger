using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarispeedDemo.SoundTouch;

namespace AudioMerger
{
    public partial class PlayerUI : Form
    {
        private readonly HomeUI homeUI;

        private WaveOutEvent outputDevice;
        private MediaFoundationReader audioFile;
        private VarispeedSampleProvider speedControl;
        private bool isPausing;

        private float playbackSpeed;

        public PlayerUI(HomeUI homeUI)
        {
            InitializeComponent();
            this.homeUI = homeUI;

            homeUI.TxtName.TextChanged += UpdateListTarget;

            this.FormClosing += (o, e) => OnPlaybackStopped(null, null);

            OnSourceFileChanged(null, null);
            UpdateListTarget(null, null);

            UpdateProcessBar();
        }

        public void OnSourceFileChanged(object o, EventArgs e)
        {
            lstSource.Items.Clear();
            lstSource.Items.AddRange(homeUI.LstSource.Items);
        }

        private void UpdateListTarget(object o, EventArgs e)
        {
            if (!homeUI.IsExported)
                return;

            lstTarget.Items.Clear();
            lstTarget.Items.Add(homeUI.TxtName.Text);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isPausing)
            {
                outputDevice.Play();
                isPausing = false;
                return;
            }

            OnPlaybackStopped(null, null);

            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }

            if (audioFile == null)
            {
                int index = lstSource.SelectedIndex;
                if (index == -1 && homeUI.IsExported)
                {
                    LoadAudioFile(homeUI.OutputPath);
                }
                else if (index > -1)
                {
                    LoadAudioFile(homeUI.FilePaths[index]);
                }
                else if (lstSource.Items.Count > 0)
                {
                    LoadAudioFile(homeUI.FilePaths[0]);
                }

                if (audioFile == null)
                {
                    return;
                }

                outputDevice.Init(speedControl);
            }

            outputDevice.Play();
        }

        private void LoadAudioFile(string filePath)
        {
            lblInfo.Text = "Playing " + FileUlti.GetFileName(filePath);
            audioFile = new MediaFoundationReader(filePath);
            speedControl = new VarispeedSampleProvider(audioFile.ToSampleProvider(), 100, new SoundTouchProfile(false, false));
            playbackSpeed = 1f;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (outputDevice == null || audioFile == null)
                return;

            if (isPausing)
            {
                outputDevice.Stop();
            }

            outputDevice?.Pause();
            isPausing = true;
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            lblInfo.Text = "Playing: None";
            outputDevice?.Dispose();
            outputDevice = null;
            audioFile?.Dispose();
            audioFile = null;
            isPausing = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnJumpBackward_Click(object sender, EventArgs e)
        {
            if (audioFile == null)
                return;

            playbackSpeed -= 0.25f;
            playbackSpeed = Math.Max(0.25f, playbackSpeed);
            speedControl.PlaybackRate = playbackSpeed;
        }

        private void btnJumpBigBackward_Click(object sender, EventArgs e)
        {
            if (audioFile == null)
                return;

            audioFile.CurrentTime -= TimeSpan.FromSeconds(Math.Min(audioFile.CurrentTime.TotalSeconds, 10));
        }

        private void btnJumpForward_Click(object sender, EventArgs e)
        {
            if (audioFile == null)
                return;

            playbackSpeed += 0.25f;
            playbackSpeed = Math.Min(4f, playbackSpeed);
            speedControl.PlaybackRate = playbackSpeed;
        }

        private void btnJumpBigForward_Click(object sender, EventArgs e)
        {
            if (audioFile == null)
                return;

            audioFile.CurrentTime += TimeSpan.FromSeconds(10);
        }

        private async void UpdateProcessBar()
        {
            await Task.Run(() =>
            {
                while (!this.IsDisposed)
                {
                    try
                    {
                        if (audioFile == null || outputDevice == null)
                        {
                            progressBar.Value = 0;
                            lblCurrentTime.Text = "00:00";
                            lblTotalTime.Text = "00:00";
                            continue;
                        }
                        progressBar.Maximum = (int)Math.Round(audioFile.TotalTime.TotalMilliseconds);
                        progressBar.Value = Math.Min((int)Math.Round(audioFile.CurrentTime.TotalMilliseconds), progressBar.Maximum);

                        lblCurrentTime.Text = audioFile.CurrentTime.ToString(@"mm\:ss");
                        lblTotalTime.Text = audioFile.TotalTime.ToString(@"mm\:ss");
                    }
                    catch (Exception) { };

                }
            });
        }

        private void lstTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSource.SelectedIndex = -1;
        }

        private void lstSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTarget.SelectedIndex = -1;
        }
    }
}
