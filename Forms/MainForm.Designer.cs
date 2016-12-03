using FaceDetection.Sources;

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
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox = new Emgu.CV.UI.ImageBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.eyesCheckBox = new System.Windows.Forms.CheckBox();
			this.noseCheckBox = new System.Windows.Forms.CheckBox();
			this.mouthCheckBox = new System.Windows.Forms.CheckBox();
			this.algorithmComboBox = new System.Windows.Forms.ComboBox();
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
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(12, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(640, 360);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(658, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Algorithms";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(658, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Additional detections";
			// 
			// eyesCheckBox
			// 
			this.eyesCheckBox.AutoSize = true;
			this.eyesCheckBox.Location = new System.Drawing.Point(661, 68);
			this.eyesCheckBox.Name = "eyesCheckBox";
			this.eyesCheckBox.Size = new System.Drawing.Size(49, 17);
			this.eyesCheckBox.TabIndex = 11;
			this.eyesCheckBox.Text = "Eyes";
			this.eyesCheckBox.UseVisualStyleBackColor = true;
			// 
			// noseCheckBox
			// 
			this.noseCheckBox.AutoSize = true;
			this.noseCheckBox.Location = new System.Drawing.Point(661, 91);
			this.noseCheckBox.Name = "noseCheckBox";
			this.noseCheckBox.Size = new System.Drawing.Size(51, 17);
			this.noseCheckBox.TabIndex = 12;
			this.noseCheckBox.Text = "Nose";
			this.noseCheckBox.UseVisualStyleBackColor = true;
			// 
			// mouthCheckBox
			// 
			this.mouthCheckBox.AutoSize = true;
			this.mouthCheckBox.Location = new System.Drawing.Point(661, 114);
			this.mouthCheckBox.Name = "mouthCheckBox";
			this.mouthCheckBox.Size = new System.Drawing.Size(56, 17);
			this.mouthCheckBox.TabIndex = 13;
			this.mouthCheckBox.Text = "Mouth";
			this.mouthCheckBox.UseVisualStyleBackColor = true;
			// 
			// algorithmComboBox
			// 
			this.algorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.algorithmComboBox.FormattingEnabled = true;
			this.algorithmComboBox.Items.AddRange(new object[] {
				"Frontal face - default",
				"Frontal face - Alt",
				"Frontal face - Alt 2",
				"Frontal face - Alt tree",
				"Profile face"});
			this.algorithmComboBox.Location = new System.Drawing.Point(661, 28);
			this.algorithmComboBox.Name = "algorithmComboBox";
			this.algorithmComboBox.Size = new System.Drawing.Size(121, 21);
			this.algorithmComboBox.TabIndex = 14;
			this.algorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.algorithmComboBox_SelectedIndexChanged);
			algorithmComboBox.SelectedIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 449);
			this.Controls.Add(this.algorithmComboBox);
			this.Controls.Add(this.mouthCheckBox);
			this.Controls.Add(this.noseCheckBox);
			this.Controls.Add(this.eyesCheckBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox);
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
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private Emgu.CV.UI.ImageBox pictureBox;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox eyesCheckBox;
		private System.Windows.Forms.CheckBox noseCheckBox;
		private System.Windows.Forms.CheckBox mouthCheckBox;
		private System.Windows.Forms.ComboBox algorithmComboBox;
	}
}