namespace FaceDetection
{
	partial class MainForm
	{
		private string fileName;
		private const int pictureWidth = 320;
		private const int pictureHeight = 240;
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.loadFileCheckBox = new System.Windows.Forms.CheckBox();
			this.webcamCheckBox = new System.Windows.Forms.CheckBox();
			this.openFileButton = new System.Windows.Forms.Button();
			this.detectButton = new System.Windows.Forms.Button();
			this.stopDetectionButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox = new Emgu.CV.UI.ImageBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// loadFileCheckBox
			// 
			this.loadFileCheckBox.AutoSize = true;
			this.loadFileCheckBox.Checked = true;
			this.loadFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.loadFileCheckBox.Location = new System.Drawing.Point(12, 382);
			this.loadFileCheckBox.Name = "loadFileCheckBox";
			this.loadFileCheckBox.Size = new System.Drawing.Size(89, 17);
			this.loadFileCheckBox.TabIndex = 1;
			this.loadFileCheckBox.Text = "Load from file";
			this.loadFileCheckBox.UseVisualStyleBackColor = true;
			this.loadFileCheckBox.CheckedChanged += new System.EventHandler(this.loadFileCheckBox_CheckedChanged);
			// 
			// webcamCheckBox
			// 
			this.webcamCheckBox.AutoSize = true;
			this.webcamCheckBox.Location = new System.Drawing.Point(12, 411);
			this.webcamCheckBox.Name = "webcamCheckBox";
			this.webcamCheckBox.Size = new System.Drawing.Size(116, 17);
			this.webcamCheckBox.TabIndex = 2;
			this.webcamCheckBox.Text = "Load from webcam";
			this.webcamCheckBox.UseVisualStyleBackColor = true;
			this.webcamCheckBox.CheckedChanged += new System.EventHandler(this.webcamCheckBox_CheckedChanged);
			// 
			// openFileButton
			// 
			this.openFileButton.Location = new System.Drawing.Point(134, 378);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(107, 23);
			this.openFileButton.TabIndex = 3;
			this.openFileButton.Text = "Open file";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
			// 
			// detectButton
			// 
			this.detectButton.Location = new System.Drawing.Point(562, 378);
			this.detectButton.Name = "detectButton";
			this.detectButton.Size = new System.Drawing.Size(90, 23);
			this.detectButton.TabIndex = 5;
			this.detectButton.Text = "Start detection";
			this.detectButton.UseVisualStyleBackColor = true;
			this.detectButton.Click += new System.EventHandler(this.detectButton_Click);
			// 
			// stopDetectionButton
			// 
			this.stopDetectionButton.Location = new System.Drawing.Point(562, 407);
			this.stopDetectionButton.Name = "stopDetectionButton";
			this.stopDetectionButton.Size = new System.Drawing.Size(90, 23);
			this.stopDetectionButton.TabIndex = 6;
			this.stopDetectionButton.Text = "Stop detection";
			this.stopDetectionButton.UseVisualStyleBackColor = true;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(12, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(640, 360);
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 449);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.stopDetectionButton);
			this.Controls.Add(this.detectButton);
			this.Controls.Add(this.openFileButton);
			this.Controls.Add(this.webcamCheckBox);
			this.Controls.Add(this.loadFileCheckBox);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckBox loadFileCheckBox;
		private System.Windows.Forms.CheckBox webcamCheckBox;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Button detectButton;
		private System.Windows.Forms.Button stopDetectionButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private Emgu.CV.UI.ImageBox pictureBox;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}