namespace AudioMerger
{
    partial class HomeUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lstSourceFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblInfoLeft = new System.Windows.Forms.Label();
            this.lblInfoRight = new System.Windows.Forms.Label();
            this.txtTargetLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radMp3 = new System.Windows.Forms.RadioButton();
            this.radWav = new System.Windows.Forms.RadioButton();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnPlayTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(22, 39);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(150, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse Source File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstSourceFiles
            // 
            this.lstSourceFiles.FormattingEnabled = true;
            this.lstSourceFiles.Location = new System.Drawing.Point(22, 84);
            this.lstSourceFiles.Name = "lstSourceFiles";
            this.lstSourceFiles.Size = new System.Drawing.Size(150, 251);
            this.lstSourceFiles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target File Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Target Format";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(239, 266);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // lblInfoLeft
            // 
            this.lblInfoLeft.AutoSize = true;
            this.lblInfoLeft.Location = new System.Drawing.Point(236, 250);
            this.lblInfoLeft.Name = "lblInfoLeft";
            this.lblInfoLeft.Size = new System.Drawing.Size(24, 13);
            this.lblInfoLeft.TabIndex = 7;
            this.lblInfoLeft.Text = "Idle";
            // 
            // lblInfoRight
            // 
            this.lblInfoRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfoRight.CausesValidation = false;
            this.lblInfoRight.Location = new System.Drawing.Point(439, 216);
            this.lblInfoRight.Name = "lblInfoRight";
            this.lblInfoRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfoRight.Size = new System.Drawing.Size(241, 47);
            this.lblInfoRight.TabIndex = 8;
            this.lblInfoRight.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtTargetLocation
            // 
            this.txtTargetLocation.Location = new System.Drawing.Point(348, 45);
            this.txtTargetLocation.Name = "txtTargetLocation";
            this.txtTargetLocation.Size = new System.Drawing.Size(329, 20);
            this.txtTargetLocation.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(348, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(329, 20);
            this.txtName.TabIndex = 10;
            // 
            // radMp3
            // 
            this.radMp3.AutoSize = true;
            this.radMp3.Checked = true;
            this.radMp3.Location = new System.Drawing.Point(348, 120);
            this.radMp3.Name = "radMp3";
            this.radMp3.Size = new System.Drawing.Size(45, 17);
            this.radMp3.TabIndex = 11;
            this.radMp3.TabStop = true;
            this.radMp3.Text = "mp3";
            this.radMp3.UseVisualStyleBackColor = true;
            // 
            // radWav
            // 
            this.radWav.AutoSize = true;
            this.radWav.Location = new System.Drawing.Point(498, 120);
            this.radWav.Name = "radWav";
            this.radWav.Size = new System.Drawing.Size(45, 17);
            this.radWav.TabIndex = 12;
            this.radWav.Text = "wav";
            this.radWav.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(601, 311);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 13;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(520, 311);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 14;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnPlayTest
            // 
            this.btnPlayTest.Location = new System.Drawing.Point(439, 311);
            this.btnPlayTest.Name = "btnPlayTest";
            this.btnPlayTest.Size = new System.Drawing.Size(75, 23);
            this.btnPlayTest.TabIndex = 15;
            this.btnPlayTest.Text = "Play Test";
            this.btnPlayTest.UseVisualStyleBackColor = true;
            this.btnPlayTest.Click += new System.EventHandler(this.btnPlayTest_Click);
            // 
            // HomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 379);
            this.Controls.Add(this.btnPlayTest);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.radWav);
            this.Controls.Add(this.radMp3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTargetLocation);
            this.Controls.Add(this.lblInfoRight);
            this.Controls.Add(this.lblInfoLeft);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSourceFiles);
            this.Controls.Add(this.btnBrowse);
            this.Name = "HomeUI";
            this.Text = "Audio Merging Apllication";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lstSourceFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblInfoLeft;
        private System.Windows.Forms.Label lblInfoRight;
        private System.Windows.Forms.TextBox txtTargetLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radMp3;
        private System.Windows.Forms.RadioButton radWav;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnPlayTest;
    }
}

