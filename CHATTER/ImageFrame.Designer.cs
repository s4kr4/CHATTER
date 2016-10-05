namespace CHATTER
{
	partial class ImageFrame
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageFrame));
			this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.Smallize_Button = new System.Windows.Forms.PictureBox();
			this.Close_Button = new System.Windows.Forms.PictureBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.SaveMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Save = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveImageDialog = new System.Windows.Forms.SaveFileDialog();
			this.RightCursor = new System.Windows.Forms.PictureBox();
			this.LeftCursor = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Smallize_Button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SaveMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RightCursor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeftCursor)).BeginInit();
			this.SuspendLayout();
			// 
			// VideoPlayer
			// 
			this.VideoPlayer.Enabled = true;
			this.VideoPlayer.Location = new System.Drawing.Point(40, 40);
			this.VideoPlayer.Name = "VideoPlayer";
			this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
			this.VideoPlayer.Size = new System.Drawing.Size(276, 248);
			this.VideoPlayer.TabIndex = 15;
			this.VideoPlayer.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.VideoPlayer_MouseDownEvent);
			// 
			// Smallize_Button
			// 
			this.Smallize_Button.BackColor = System.Drawing.Color.Black;
			this.Smallize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Smallize_Button.Image = global::CHATTER.Properties.Resources.Smallize;
			this.Smallize_Button.Location = new System.Drawing.Point(237, 10);
			this.Smallize_Button.Name = "Smallize_Button";
			this.Smallize_Button.Size = new System.Drawing.Size(24, 24);
			this.Smallize_Button.TabIndex = 14;
			this.Smallize_Button.TabStop = false;
			this.Smallize_Button.Click += new System.EventHandler(this.Smallize_Button_Click);
			// 
			// Close_Button
			// 
			this.Close_Button.BackColor = System.Drawing.Color.Black;
			this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Close_Button.Image = global::CHATTER.Properties.Resources.Close;
			this.Close_Button.Location = new System.Drawing.Point(264, 10);
			this.Close_Button.Name = "Close_Button";
			this.Close_Button.Size = new System.Drawing.Size(24, 24);
			this.Close_Button.TabIndex = 13;
			this.Close_Button.TabStop = false;
			this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.InitialImage = global::CHATTER.Properties.Resources.loading;
			this.pictureBox.Location = new System.Drawing.Point(40, 40);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox.MaximumSize = new System.Drawing.Size(1200, 650);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(280, 248);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
			// 
			// SaveMenu
			// 
			this.SaveMenu.BackColor = System.Drawing.Color.Black;
			this.SaveMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save});
			this.SaveMenu.Name = "contextMenuStrip1";
			this.SaveMenu.ShowImageMargin = false;
			this.SaveMenu.Size = new System.Drawing.Size(74, 26);
			this.SaveMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SaveMenu_ItemClicked);
			// 
			// Save
			// 
			this.Save.ForeColor = System.Drawing.Color.White;
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(73, 22);
			this.Save.Text = "保存";
			// 
			// SaveImageDialog
			// 
			this.SaveImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveImageDialog_FileOk);
			// 
			// RightCursor
			// 
			this.RightCursor.BackColor = System.Drawing.Color.Transparent;
			this.RightCursor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RightCursor.Image = global::CHATTER.Properties.Resources.CursorLeft;
			this.RightCursor.Location = new System.Drawing.Point(325, 120);
			this.RightCursor.Name = "RightCursor";
			this.RightCursor.Size = new System.Drawing.Size(30, 60);
			this.RightCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.RightCursor.TabIndex = 16;
			this.RightCursor.TabStop = false;
			this.RightCursor.Visible = false;
			this.RightCursor.Click += new System.EventHandler(this.RightCursor_Click);
			// 
			// LeftCursor
			// 
			this.LeftCursor.BackColor = System.Drawing.Color.Transparent;
			this.LeftCursor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LeftCursor.Image = global::CHATTER.Properties.Resources.CursorRight;
			this.LeftCursor.Location = new System.Drawing.Point(5, 120);
			this.LeftCursor.Name = "LeftCursor";
			this.LeftCursor.Size = new System.Drawing.Size(30, 60);
			this.LeftCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LeftCursor.TabIndex = 17;
			this.LeftCursor.TabStop = false;
			this.LeftCursor.Visible = false;
			this.LeftCursor.Click += new System.EventHandler(this.LeftCursor_Click);
			// 
			// ImageFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(360, 300);
			this.Controls.Add(this.LeftCursor);
			this.Controls.Add(this.RightCursor);
			this.Controls.Add(this.VideoPlayer);
			this.Controls.Add(this.Smallize_Button);
			this.Controls.Add(this.Close_Button);
			this.Controls.Add(this.pictureBox);
			this.MaximumSize = new System.Drawing.Size(1340, 720);
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "ImageFrame";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "ImageFrame";
			this.Load += new System.EventHandler(this.ImageFrame_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageFrame_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Smallize_Button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.SaveMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RightCursor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeftCursor)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.PictureBox Smallize_Button;
		private System.Windows.Forms.PictureBox Close_Button;
		private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
		private System.Windows.Forms.ContextMenuStrip SaveMenu;
		private System.Windows.Forms.ToolStripMenuItem Save;
		private System.Windows.Forms.SaveFileDialog SaveImageDialog;
		private System.Windows.Forms.PictureBox RightCursor;
		private System.Windows.Forms.PictureBox LeftCursor;
	}
}