namespace FaceDetection
{
	partial class MainForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkFile = new System.Windows.Forms.CheckBox();
			this.checkCam = new System.Windows.Forms.CheckBox();
			this.buttonStartDetection = new System.Windows.Forms.Button();
			this.buttonOpenFile = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(13, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(640, 480);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// checkFile
			// 
			this.checkFile.AutoSize = true;
			this.checkFile.Location = new System.Drawing.Point(13, 499);
			this.checkFile.Name = "checkFile";
			this.checkFile.Size = new System.Drawing.Size(91, 17);
			this.checkFile.TabIndex = 1;
			this.checkFile.Text = "Read from file";
			this.checkFile.UseVisualStyleBackColor = true;
			// 
			// checkCam
			// 
			this.checkCam.AutoSize = true;
			this.checkCam.Location = new System.Drawing.Point(13, 522);
			this.checkCam.Name = "checkCam";
			this.checkCam.Size = new System.Drawing.Size(121, 17);
			this.checkCam.TabIndex = 2;
			this.checkCam.Text = "Read from web cam";
			this.checkCam.UseVisualStyleBackColor = true;
			this.checkCam.CheckedChanged += new System.EventHandler(this.checkCam_CheckedChanged);
			// 
			// buttonStartDetection
			// 
			this.buttonStartDetection.Location = new System.Drawing.Point(556, 516);
			this.buttonStartDetection.Name = "buttonStartDetection";
			this.buttonStartDetection.Size = new System.Drawing.Size(97, 23);
			this.buttonStartDetection.TabIndex = 3;
			this.buttonStartDetection.Text = "Start detection";
			this.buttonStartDetection.UseVisualStyleBackColor = true;
			this.buttonStartDetection.Click += new System.EventHandler(this.buttonStartDetection_Click);
			// 
			// buttonOpenFile
			// 
			this.buttonOpenFile.Location = new System.Drawing.Point(159, 516);
			this.buttonOpenFile.Name = "buttonOpenFile";
			this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
			this.buttonOpenFile.TabIndex = 4;
			this.buttonOpenFile.Text = "Open file";
			this.buttonOpenFile.UseVisualStyleBackColor = true;
			this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "File";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 547);
			this.Controls.Add(this.buttonOpenFile);
			this.Controls.Add(this.buttonStartDetection);
			this.Controls.Add(this.checkCam);
			this.Controls.Add(this.checkFile);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Face detection";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkFile;
		private System.Windows.Forms.CheckBox checkCam;
		private System.Windows.Forms.Button buttonStartDetection;
		private System.Windows.Forms.Button buttonOpenFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

