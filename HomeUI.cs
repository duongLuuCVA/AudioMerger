using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioMerger
{
    public partial class HomeUI : Form
    {
        private readonly List<string> filePaths = new List<string>();
        private PlayerUI playerUI;

        public HomeUI()
        {
            InitializeComponent();
            Merger = new Merger(this);

            txtTargetLocation.Text = @"D:\Temporary";
            txtName.Text = @"output";
            BtnFinish.Enabled = false;
        }

        public List<string> FilePaths => filePaths;
        public Merger Merger { get; private set; }
        public bool IsExported { get; private set; }

        public ProgressBar ProgressBar => progressBar1;
        public Label LblInfoLeft => lblInfoLeft;
        public Label LblInfoRight => lblInfoRight;

        public Button BtnMerge => btnMerge;
        public Button BtnFinish => btnFinish;
        public TextBox TxtName => txtName;
        public ListBox LstSource => lstSourceFiles;
        public string OutputPath => txtTargetLocation.Text + "\\"
                + txtName.Text + (radMp3.Checked ? ".mp3" : ".wav");
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "audio files (*.mp3;*.wav)|*.wav;*.mp3";
            openFileDialog.Title = "Browse File";
            openFileDialog.DefaultExt = "wav";
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = true;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (var item in openFileDialog.FileNames)
                {
                    lstSourceFiles.Items.Add(item.Substring(item.LastIndexOf("\\") + 1));
                    filePaths.Add(item);
                }
                playerUI?.OnSourceFileChanged(null, null);
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (btnMerge.Text == "Cancel")
            {
                Merger.IsStop = true;
                btnMerge.Text = "Merge";
                return;
            }

            btnMerge.Text = "Cancel";

            Merger.IsOutputToMpeg = radMp3.Checked;
            Merger.Combine(filePaths.ToArray(), OutputPath);

            IsExported = true;
        }

        private void btnPlayTest_Click(object sender, EventArgs e)
        {
            if (playerUI == null || playerUI.IsDisposed)
            {
                playerUI = new PlayerUI(this);
            }
            playerUI.Activate();
            playerUI.Show();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
