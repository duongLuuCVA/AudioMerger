namespace AudioMerger
{
    partial class PlayerUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.lstTarget = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJumpBigForward = new System.Windows.Forms.Button();
            this.btnJumpForward = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnJumpBackward = new System.Windows.Forms.Button();
            this.btnJumpBigBackward = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblInfo = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Location = new System.Drawing.Point(16, 40);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(153, 199);
            this.lstSource.TabIndex = 1;
            this.lstSource.SelectedIndexChanged += new System.EventHandler(this.lstSource_SelectedIndexChanged);
            // 
            // lstTarget
            // 
            this.lstTarget.FormattingEnabled = true;
            this.lstTarget.Location = new System.Drawing.Point(16, 270);
            this.lstTarget.Name = "lstTarget";
            this.lstTarget.Size = new System.Drawing.Size(153, 56);
            this.lstTarget.TabIndex = 3;
            this.lstTarget.SelectedIndexChanged += new System.EventHandler(this.lstTarget_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCurrentTime);
            this.panel1.Controls.Add(this.lblTotalTime);
            this.panel1.Controls.Add(this.btnJumpBigForward);
            this.panel1.Controls.Add(this.btnJumpForward);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnJumpBackward);
            this.panel1.Controls.Add(this.btnJumpBigBackward);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(232, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 199);
            this.panel1.TabIndex = 4;
            // 
            // btnJumpBigForward
            // 
            this.btnJumpBigForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJumpBigForward.Location = new System.Drawing.Point(297, 134);
            this.btnJumpBigForward.Name = "btnJumpBigForward";
            this.btnJumpBigForward.Size = new System.Drawing.Size(32, 23);
            this.btnJumpBigForward.TabIndex = 7;
            this.btnJumpBigForward.Text = ">>|";
            this.btnJumpBigForward.UseVisualStyleBackColor = true;
            this.btnJumpBigForward.Click += new System.EventHandler(this.btnJumpBigForward_Click);
            // 
            // btnJumpForward
            // 
            this.btnJumpForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJumpForward.Location = new System.Drawing.Point(259, 134);
            this.btnJumpForward.Name = "btnJumpForward";
            this.btnJumpForward.Size = new System.Drawing.Size(32, 23);
            this.btnJumpForward.TabIndex = 6;
            this.btnJumpForward.Text = ">>";
            this.btnJumpForward.UseVisualStyleBackColor = true;
            this.btnJumpForward.Click += new System.EventHandler(this.btnJumpForward_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(221, 134);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = ">";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnJumpBackward
            // 
            this.btnJumpBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJumpBackward.Location = new System.Drawing.Point(183, 134);
            this.btnJumpBackward.Name = "btnJumpBackward";
            this.btnJumpBackward.Size = new System.Drawing.Size(32, 23);
            this.btnJumpBackward.TabIndex = 4;
            this.btnJumpBackward.Text = "<<";
            this.btnJumpBackward.UseVisualStyleBackColor = true;
            this.btnJumpBackward.Click += new System.EventHandler(this.btnJumpBackward_Click);
            // 
            // btnJumpBigBackward
            // 
            this.btnJumpBigBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJumpBigBackward.Location = new System.Drawing.Point(145, 134);
            this.btnJumpBigBackward.Name = "btnJumpBigBackward";
            this.btnJumpBigBackward.Size = new System.Drawing.Size(32, 23);
            this.btnJumpBigBackward.TabIndex = 3;
            this.btnJumpBigBackward.Text = "|<<";
            this.btnJumpBigBackward.UseVisualStyleBackColor = true;
            this.btnJumpBigBackward.Click += new System.EventHandler(this.btnJumpBigBackward_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(107, 134);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(32, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "⬛";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(22, 56);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(380, 23);
            this.progressBar.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(19, 21);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(73, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Playing: None";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(582, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Close";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTime.Location = new System.Drawing.Point(302, 82);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(100, 23);
            this.lblTotalTime.TabIndex = 8;
            this.lblTotalTime.Text = "00:00";
            this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.Location = new System.Drawing.Point(19, 82);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentTime.TabIndex = 9;
            this.lblCurrentTime.Text = "00:00";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 379);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.label1);
            this.Name = "PlayerUI";
            this.Text = "PlayerUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.ListBox lstTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJumpBigForward;
        private System.Windows.Forms.Button btnJumpForward;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnJumpBackward;
        private System.Windows.Forms.Button btnJumpBigBackward;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTotalTime;
    }
}