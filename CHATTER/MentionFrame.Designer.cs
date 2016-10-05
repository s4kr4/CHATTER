namespace CHATTER
{
	partial class MentionFrame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MentionFrame));
			this.CursorLD = new System.Windows.Forms.PictureBox();
			this.CursorLU = new System.Windows.Forms.PictureBox();
			this.CursorRD = new System.Windows.Forms.PictureBox();
			this.CursorRU = new System.Windows.Forms.PictureBox();
			this.DCursorRD = new System.Windows.Forms.PictureBox();
			this.DCursorRU = new System.Windows.Forms.PictureBox();
			this.StringCount = new System.Windows.Forms.Label();
			this.SendButton = new System.Windows.Forms.Label();
			this.InputBox = new System.Windows.Forms.TextBox();
			this.SmallizeButton = new System.Windows.Forms.PictureBox();
			this.CloseButton = new System.Windows.Forms.PictureBox();
			this.MentionList = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.CursorLD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLU)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRU)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DCursorRD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DCursorRU)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallizeButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
			this.SuspendLayout();
			// 
			// CursorLD
			// 
			this.CursorLD.BackColor = System.Drawing.Color.Transparent;
			this.CursorLD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CursorLD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorLD.Image = global::CHATTER.Properties.Resources.CursorDown;
			this.CursorLD.Location = new System.Drawing.Point(12, 460);
			this.CursorLD.Name = "CursorLD";
			this.CursorLD.Size = new System.Drawing.Size(44, 26);
			this.CursorLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CursorLD.TabIndex = 32;
			this.CursorLD.TabStop = false;
			this.CursorLD.Click += new System.EventHandler(this.CursorLD_Click);
			// 
			// CursorLU
			// 
			this.CursorLU.BackColor = System.Drawing.Color.Transparent;
			this.CursorLU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CursorLU.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorLU.Image = ((System.Drawing.Image)(resources.GetObject("CursorLU.Image")));
			this.CursorLU.Location = new System.Drawing.Point(12, 136);
			this.CursorLU.Name = "CursorLU";
			this.CursorLU.Size = new System.Drawing.Size(44, 26);
			this.CursorLU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CursorLU.TabIndex = 31;
			this.CursorLU.TabStop = false;
			this.CursorLU.Click += new System.EventHandler(this.CursorLU_Click);
			// 
			// CursorRD
			// 
			this.CursorRD.BackColor = System.Drawing.Color.Transparent;
			this.CursorRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CursorRD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorRD.Image = global::CHATTER.Properties.Resources.CursorDown;
			this.CursorRD.Location = new System.Drawing.Point(344, 408);
			this.CursorRD.Name = "CursorRD";
			this.CursorRD.Size = new System.Drawing.Size(44, 26);
			this.CursorRD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CursorRD.TabIndex = 30;
			this.CursorRD.TabStop = false;
			this.CursorRD.Click += new System.EventHandler(this.CursorRD_Click);
			// 
			// CursorRU
			// 
			this.CursorRU.BackColor = System.Drawing.Color.Transparent;
			this.CursorRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CursorRU.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorRU.Image = ((System.Drawing.Image)(resources.GetObject("CursorRU.Image")));
			this.CursorRU.Location = new System.Drawing.Point(344, 188);
			this.CursorRU.Name = "CursorRU";
			this.CursorRU.Size = new System.Drawing.Size(44, 26);
			this.CursorRU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CursorRU.TabIndex = 29;
			this.CursorRU.TabStop = false;
			this.CursorRU.Click += new System.EventHandler(this.CursorRU_Click);
			// 
			// DCursorRD
			// 
			this.DCursorRD.BackColor = System.Drawing.Color.Transparent;
			this.DCursorRD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DCursorRD.Image = global::CHATTER.Properties.Resources.CursorDoubleDown;
			this.DCursorRD.Location = new System.Drawing.Point(344, 440);
			this.DCursorRD.Name = "DCursorRD";
			this.DCursorRD.Size = new System.Drawing.Size(44, 46);
			this.DCursorRD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DCursorRD.TabIndex = 28;
			this.DCursorRD.TabStop = false;
			this.DCursorRD.Click += new System.EventHandler(this.DCursorRD_Click);
			// 
			// DCursorRU
			// 
			this.DCursorRU.BackColor = System.Drawing.Color.Transparent;
			this.DCursorRU.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DCursorRU.Image = global::CHATTER.Properties.Resources.CursorDoubleUp;
			this.DCursorRU.Location = new System.Drawing.Point(344, 136);
			this.DCursorRU.Name = "DCursorRU";
			this.DCursorRU.Size = new System.Drawing.Size(44, 46);
			this.DCursorRU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DCursorRU.TabIndex = 27;
			this.DCursorRU.TabStop = false;
			this.DCursorRU.Click += new System.EventHandler(this.DCursorRU_Click);
			// 
			// StringCount
			// 
			this.StringCount.AutoSize = true;
			this.StringCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.StringCount.ForeColor = System.Drawing.Color.White;
			this.StringCount.Location = new System.Drawing.Point(244, 544);
			this.StringCount.Name = "StringCount";
			this.StringCount.Size = new System.Drawing.Size(40, 24);
			this.StringCount.TabIndex = 17;
			this.StringCount.Text = "140";
			// 
			// SendButton
			// 
			this.SendButton.BackColor = System.Drawing.Color.Black;
			this.SendButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SendButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.SendButton.ForeColor = System.Drawing.Color.White;
			this.SendButton.Location = new System.Drawing.Point(290, 542);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(45, 28);
			this.SendButton.TabIndex = 16;
			this.SendButton.Text = "奏神";
			this.SendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
			// 
			// InputBox
			// 
			this.InputBox.BackColor = System.Drawing.Color.Black;
			this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.InputBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.InputBox.ForeColor = System.Drawing.Color.White;
			this.InputBox.Location = new System.Drawing.Point(65, 489);
			this.InputBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.InputBox.MaxLength = 280;
			this.InputBox.Multiline = true;
			this.InputBox.Name = "InputBox";
			this.InputBox.Size = new System.Drawing.Size(270, 50);
			this.InputBox.TabIndex = 15;
			this.InputBox.TextChanged += new System.EventHandler(this.MessageBox_TextChanged);
			this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBox_KeyDown);
			// 
			// SmallizeButton
			// 
			this.SmallizeButton.BackColor = System.Drawing.Color.Black;
			this.SmallizeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SmallizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SmallizeButton.Image = global::CHATTER.Properties.Resources.Smallize;
			this.SmallizeButton.Location = new System.Drawing.Point(269, 40);
			this.SmallizeButton.Name = "SmallizeButton";
			this.SmallizeButton.Size = new System.Drawing.Size(30, 30);
			this.SmallizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SmallizeButton.TabIndex = 14;
			this.SmallizeButton.TabStop = false;
			this.SmallizeButton.Click += new System.EventHandler(this.SmallizeButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.Black;
			this.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.Image = global::CHATTER.Properties.Resources.Close;
			this.CloseButton.Location = new System.Drawing.Point(305, 40);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(30, 30);
			this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CloseButton.TabIndex = 13;
			this.CloseButton.TabStop = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// MentionList
			// 
			this.MentionList.AutoScroll = true;
			this.MentionList.BackColor = System.Drawing.Color.Black;
			this.MentionList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MentionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MentionList.Location = new System.Drawing.Point(65, 136);
			this.MentionList.Name = "MentionList";
			this.MentionList.Size = new System.Drawing.Size(270, 350);
			this.MentionList.TabIndex = 0;
			// 
			// MentionFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(400, 600);
			this.Controls.Add(this.CursorLD);
			this.Controls.Add(this.CursorLU);
			this.Controls.Add(this.CursorRD);
			this.Controls.Add(this.CursorRU);
			this.Controls.Add(this.DCursorRD);
			this.Controls.Add(this.DCursorRU);
			this.Controls.Add(this.StringCount);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.InputBox);
			this.Controls.Add(this.SmallizeButton);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.MentionList);
			this.DoubleBuffered = true;
			this.MinimumSize = new System.Drawing.Size(400, 600);
			this.Name = "MentionFrame";
			this.Text = "MontionFrame";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MentionFrame_FormClosing);
			this.Load += new System.EventHandler(this.MentionFrame_Load);
			((System.ComponentModel.ISupportInitialize)(this.CursorLD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLU)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRU)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DCursorRD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DCursorRU)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallizeButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel MentionList;
		private System.Windows.Forms.PictureBox CloseButton;
		private System.Windows.Forms.PictureBox SmallizeButton;
		private System.Windows.Forms.TextBox InputBox;
		private System.Windows.Forms.Label SendButton;
		private System.Windows.Forms.Label StringCount;
		private System.Windows.Forms.PictureBox CursorLD;
		private System.Windows.Forms.PictureBox CursorLU;
		private System.Windows.Forms.PictureBox CursorRD;
		private System.Windows.Forms.PictureBox CursorRU;
		private System.Windows.Forms.PictureBox DCursorRD;
		private System.Windows.Forms.PictureBox DCursorRU;
	}
}