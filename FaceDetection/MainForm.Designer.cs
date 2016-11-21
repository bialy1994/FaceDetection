namespace FaceDetection
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			pictureBox1 = new System.Windows.Forms.PictureBox();
			checkFile = new System.Windows.Forms.CheckBox();
			checkCam = new System.Windows.Forms.CheckBox();
			buttonStartDetection = new System.Windows.Forms.Button();
			buttonOpenFile = new System.Windows.Forms.Button();
			openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			pictureBox1.Location = new System.Drawing.Point(13, 13);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(320, 240);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// checkFile
			// 
			checkFile.AutoSize = true;
			checkFile.Location = new System.Drawing.Point(13, 259);
			checkFile.Name = "checkFile";
			checkFile.Size = new System.Drawing.Size(91, 17);
			checkFile.TabIndex = 1;
			checkFile.Text = "Read from file";
			checkFile.UseVisualStyleBackColor = true;
			checkFile.CheckedChanged += new System.EventHandler(checkFile_CheckedChanged);
			// 
			// checkCam
			// 
			checkCam.AutoSize = true;
			checkCam.Location = new System.Drawing.Point(13, 282);
			checkCam.Name = "checkCam";
			checkCam.Size = new System.Drawing.Size(121, 17);
			checkCam.TabIndex = 2;
			checkCam.Text = "Read from web cam";
			checkCam.UseVisualStyleBackColor = true;
			checkCam.CheckedChanged += new System.EventHandler(checkCam_CheckedChanged);
			// 
			// buttonStartDetection
			// 
			buttonStartDetection.Location = new System.Drawing.Point(236, 276);
			buttonStartDetection.Name = "buttonStartDetection";
			buttonStartDetection.Size = new System.Drawing.Size(97, 23);
			buttonStartDetection.TabIndex = 3;
			buttonStartDetection.Text = "Start detection";
			buttonStartDetection.UseVisualStyleBackColor = true;
			buttonStartDetection.Click += new System.EventHandler(buttonStartDetection_Click);
			// 
			// buttonOpenFile
			// 
			buttonOpenFile.Location = new System.Drawing.Point(155, 276);
			buttonOpenFile.Name = "buttonOpenFile";
			buttonOpenFile.Size = new System.Drawing.Size(75, 23);
			buttonOpenFile.TabIndex = 4;
			buttonOpenFile.Text = "Open file";
			buttonOpenFile.UseVisualStyleBackColor = true;
			buttonOpenFile.Click += new System.EventHandler(buttonOpenFile_Click);
			buttonOpenFile.Enabled = false;
			// 
			// openFileDialog
			// 
			openFileDialog.FileName = "File";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(344, 309);
			Controls.Add(buttonOpenFile);
			Controls.Add(buttonStartDetection);
			Controls.Add(checkCam);
			Controls.Add(checkFile);
			Controls.Add(pictureBox1);
			Name = "MainForm";
			Text = "Face detection";
			((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkFile;
		private System.Windows.Forms.CheckBox checkCam;
		private System.Windows.Forms.Button buttonStartDetection;
		private System.Windows.Forms.Button buttonOpenFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

