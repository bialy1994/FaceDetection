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
			components = new System.ComponentModel.Container();
			loadFileCheckBox = new System.Windows.Forms.CheckBox();
			webcamCheckBox = new System.Windows.Forms.CheckBox();
			openFileButton = new System.Windows.Forms.Button();
			detectButton = new System.Windows.Forms.Button();
			openFileDialog = new System.Windows.Forms.OpenFileDialog();
			pictureBox = new Emgu.CV.UI.ImageBox();
			saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			label1 = new System.Windows.Forms.Label();
			frontalFaceCheckBox = new System.Windows.Forms.CheckBox();
			profileFaceCheckBox = new System.Windows.Forms.CheckBox();
			label2 = new System.Windows.Forms.Label();
			eyesCheckBox = new System.Windows.Forms.CheckBox();
			noseCheckBox = new System.Windows.Forms.CheckBox();
			mouthCheckBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(pictureBox)).BeginInit();
			SuspendLayout();
			// 
			// loadFileCheckBox
			// 
			loadFileCheckBox.AutoSize = true;
			loadFileCheckBox.Checked = true;
			loadFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			loadFileCheckBox.Location = new System.Drawing.Point(12, 382);
			loadFileCheckBox.Name = "loadFileCheckBox";
			loadFileCheckBox.Size = new System.Drawing.Size(89, 17);
			loadFileCheckBox.TabIndex = 1;
			loadFileCheckBox.Text = "Load from file";
			loadFileCheckBox.UseVisualStyleBackColor = true;
			loadFileCheckBox.CheckedChanged += new System.EventHandler(loadFileCheckBox_CheckedChanged);
			// 
			// webcamCheckBox
			// 
			webcamCheckBox.AutoSize = true;
			webcamCheckBox.Location = new System.Drawing.Point(12, 411);
			webcamCheckBox.Name = "webcamCheckBox";
			webcamCheckBox.Size = new System.Drawing.Size(116, 17);
			webcamCheckBox.TabIndex = 2;
			webcamCheckBox.Text = "Load from webcam";
			webcamCheckBox.UseVisualStyleBackColor = true;
			webcamCheckBox.CheckedChanged += new System.EventHandler(webcamCheckBox_CheckedChanged);
			// 
			// openFileButton
			// 
			openFileButton.Location = new System.Drawing.Point(134, 378);
			openFileButton.Name = "openFileButton";
			openFileButton.Size = new System.Drawing.Size(107, 23);
			openFileButton.TabIndex = 3;
			openFileButton.Text = "Open file";
			openFileButton.UseVisualStyleBackColor = true;
			openFileButton.Click += new System.EventHandler(openFileButton_Click);
			// 
			// detectButton
			// 
			detectButton.Location = new System.Drawing.Point(562, 378);
			detectButton.Name = "detectButton";
			detectButton.Size = new System.Drawing.Size(90, 23);
			detectButton.TabIndex = 5;
			detectButton.Text = "Start detection";
			detectButton.UseVisualStyleBackColor = true;
			detectButton.Click += new System.EventHandler(detectButton_Click);
			// 
			// openFileDialog
			// 
			openFileDialog.FileName = "openFileDialog1";
			// 
			// pictureBox
			// 
			pictureBox.Location = new System.Drawing.Point(12, 12);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new System.Drawing.Size(640, 360);
			pictureBox.TabIndex = 2;
			pictureBox.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(658, 12);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(55, 13);
			label1.TabIndex = 7;
			label1.Text = "Algorithms";
			// 
			// frontalFaceCheckBox
			// 
			frontalFaceCheckBox.AutoSize = true;
			frontalFaceCheckBox.Location = new System.Drawing.Point(661, 28);
			frontalFaceCheckBox.Name = "frontalFaceCheckBox";
			frontalFaceCheckBox.Size = new System.Drawing.Size(82, 17);
			frontalFaceCheckBox.TabIndex = 8;
			frontalFaceCheckBox.Text = "Frontal face";
			frontalFaceCheckBox.UseVisualStyleBackColor = true;
			frontalFaceCheckBox.CheckedChanged += new System.EventHandler(frontalFaceCheckBox_CheckedChanged);
			frontalFaceCheckBox.Checked = true;
			// 
			// profileFaceCheckBox
			// 
			profileFaceCheckBox.AutoSize = true;
			profileFaceCheckBox.Location = new System.Drawing.Point(661, 51);
			profileFaceCheckBox.Name = "profileFaceCheckBox";
			profileFaceCheckBox.Size = new System.Drawing.Size(82, 17);
			profileFaceCheckBox.TabIndex = 9;
			profileFaceCheckBox.Text = "Profile Face";
			profileFaceCheckBox.UseVisualStyleBackColor = true;
			profileFaceCheckBox.CheckedChanged += new System.EventHandler(profileFaceCheckBox_CheckedChanged);
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(658, 71);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(105, 13);
			label2.TabIndex = 10;
			label2.Text = "Additional detections";
			// 
			// eyesCheckBox
			// 
			eyesCheckBox.AutoSize = true;
			eyesCheckBox.Location = new System.Drawing.Point(661, 87);
			eyesCheckBox.Name = "eyesCheckBox";
			eyesCheckBox.Size = new System.Drawing.Size(49, 17);
			eyesCheckBox.TabIndex = 11;
			eyesCheckBox.Text = "Eyes";
			eyesCheckBox.UseVisualStyleBackColor = true;
			// 
			// noseCheckBox
			// 
			noseCheckBox.AutoSize = true;
			noseCheckBox.Location = new System.Drawing.Point(661, 110);
			noseCheckBox.Name = "noseCheckBox";
			noseCheckBox.Size = new System.Drawing.Size(51, 17);
			noseCheckBox.TabIndex = 12;
			noseCheckBox.Text = "Nose";
			noseCheckBox.UseVisualStyleBackColor = true;
			// 
			// mouthCheckBox
			// 
			mouthCheckBox.AutoSize = true;
			mouthCheckBox.Location = new System.Drawing.Point(661, 133);
			mouthCheckBox.Name = "mouthCheckBox";
			mouthCheckBox.Size = new System.Drawing.Size(56, 17);
			mouthCheckBox.TabIndex = 13;
			mouthCheckBox.Text = "Mouth";
			mouthCheckBox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(773, 449);
			Controls.Add(mouthCheckBox);
			Controls.Add(noseCheckBox);
			Controls.Add(eyesCheckBox);
			Controls.Add(label2);
			Controls.Add(profileFaceCheckBox);
			Controls.Add(frontalFaceCheckBox);
			Controls.Add(label1);
			Controls.Add(pictureBox);
			Controls.Add(detectButton);
			Controls.Add(openFileButton);
			Controls.Add(webcamCheckBox);
			Controls.Add(loadFileCheckBox);
			Name = "MainForm";
			Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(pictureBox)).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckBox loadFileCheckBox;
		private System.Windows.Forms.CheckBox webcamCheckBox;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Button detectButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private Emgu.CV.UI.ImageBox pictureBox;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox frontalFaceCheckBox;
		private System.Windows.Forms.CheckBox profileFaceCheckBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox eyesCheckBox;
		private System.Windows.Forms.CheckBox noseCheckBox;
		private System.Windows.Forms.CheckBox mouthCheckBox;
	}
}