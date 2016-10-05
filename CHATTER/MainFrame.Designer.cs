namespace CHATTER
{
	partial class MainFrame
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
			this.TweetBox = new System.Windows.Forms.TextBox();
			this.myIcon = new System.Windows.Forms.PictureBox();
			this.TitleLabelA = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.PictureBox();
			this.SmallizeButton = new System.Windows.Forms.PictureBox();
			this.Reload_Button = new System.Windows.Forms.Label();
			this.SendButton = new System.Windows.Forms.Label();
			this.NotificationBox = new System.Windows.Forms.RichTextBox();
			this.TimeLine = new System.Windows.Forms.FlowLayoutPanel();
			this.CursorRU = new System.Windows.Forms.PictureBox();
			this.CursorRD = new System.Windows.Forms.PictureBox();
			this.CursorLD = new System.Windows.Forms.PictureBox();
			this.CursorLU = new System.Windows.Forms.PictureBox();
			this.DCursorRU = new System.Windows.Forms.PictureBox();
			this.DCursorRD = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.UploadImageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Cancel = new System.Windows.Forms.ToolStripMenuItem();
			this.TitleLabelB = new System.Windows.Forms.Label();
			this.CursorRightButtom = new System.Windows.Forms.PictureBox();
			this.CursorLeftButtom = new System.Windows.Forms.PictureBox();
			this.CursorLeftTop = new System.Windows.Forms.PictureBox();
			this.CursorRightTop = new System.Windows.Forms.PictureBox();
			this.Settings = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.myIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallizeButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRU)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLU)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DCursorRU)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DCursorRD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.UploadImageMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CursorRightButtom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLeftButtom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLeftTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRightTop)).BeginInit();
			this.SuspendLayout();
			// 
			// TweetBox
			// 
			this.TweetBox.AllowDrop = true;
			this.TweetBox.BackColor = System.Drawing.Color.Black;
			this.TweetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TweetBox.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TweetBox.ForeColor = System.Drawing.Color.White;
			this.TweetBox.Location = new System.Drawing.Point(100, 506);
			this.TweetBox.MaxLength = 0;
			this.TweetBox.Multiline = true;
			this.TweetBox.Name = "TweetBox";
			this.TweetBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TweetBox.Size = new System.Drawing.Size(540, 56);
			this.TweetBox.TabIndex = 0;
			this.TweetBox.TextChanged += new System.EventHandler(this.TweetBox_TextChanged);
			this.TweetBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TweetBox_DragDrop);
			this.TweetBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TweetBox_DragEnter);
			this.TweetBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TweetBox_KeyDown);
			this.TweetBox.MouseEnter += new System.EventHandler(this.TweetBox_MouseEnter);
			// 
			// myIcon
			// 
			this.myIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.myIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.myIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.myIcon.Image = global::CHATTER.Properties.Resources.retweet_a;
			this.myIcon.Location = new System.Drawing.Point(77, 51);
			this.myIcon.Name = "myIcon";
			this.myIcon.Size = new System.Drawing.Size(90, 90);
			this.myIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.myIcon.TabIndex = 4;
			this.myIcon.TabStop = false;
			this.myIcon.Click += new System.EventHandler(this.myIcon_Click);
			// 
			// TitleLabelA
			// 
			this.TitleLabelA.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabelA.Font = new System.Drawing.Font("HGS明朝E", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TitleLabelA.ForeColor = System.Drawing.Color.White;
			this.TitleLabelA.Location = new System.Drawing.Point(114, 153);
			this.TitleLabelA.Name = "TitleLabelA";
			this.TitleLabelA.Size = new System.Drawing.Size(600, 25);
			this.TitleLabelA.TabIndex = 10;
			this.TitleLabelA.Text = "実況通神";
			this.TitleLabelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleLabelA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
			this.TitleLabelA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.Black;
			this.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.Image = global::CHATTER.Properties.Resources.Close;
			this.CloseButton.Location = new System.Drawing.Point(695, 51);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(30, 30);
			this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CloseButton.TabIndex = 11;
			this.CloseButton.TabStop = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// SmallizeButton
			// 
			this.SmallizeButton.BackColor = System.Drawing.Color.Black;
			this.SmallizeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SmallizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SmallizeButton.Image = global::CHATTER.Properties.Resources.Smallize;
			this.SmallizeButton.Location = new System.Drawing.Point(659, 51);
			this.SmallizeButton.Name = "SmallizeButton";
			this.SmallizeButton.Size = new System.Drawing.Size(30, 30);
			this.SmallizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SmallizeButton.TabIndex = 12;
			this.SmallizeButton.TabStop = false;
			this.SmallizeButton.Click += new System.EventHandler(this.SmallizeButton_Click);
			// 
			// Reload_Button
			// 
			this.Reload_Button.BackColor = System.Drawing.Color.Black;
			this.Reload_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Reload_Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Reload_Button.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Reload_Button.ForeColor = System.Drawing.Color.White;
			this.Reload_Button.Location = new System.Drawing.Point(660, 119);
			this.Reload_Button.Name = "Reload_Button";
			this.Reload_Button.Size = new System.Drawing.Size(65, 22);
			this.Reload_Button.TabIndex = 3;
			this.Reload_Button.Text = "再読込";
			this.Reload_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Reload_Button.Click += new System.EventHandler(this.Reload_Click);
			// 
			// SendButton
			// 
			this.SendButton.BackColor = System.Drawing.Color.Black;
			this.SendButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SendButton.Font = new System.Drawing.Font("Meiryo UI", 10F);
			this.SendButton.ForeColor = System.Drawing.Color.White;
			this.SendButton.Location = new System.Drawing.Point(646, 506);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(56, 56);
			this.SendButton.TabIndex = 1;
			this.SendButton.Text = "送神\r\n140";
			this.SendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SendButton.Click += new System.EventHandler(this.Send_Click);
			// 
			// NotificationBox
			// 
			this.NotificationBox.BackColor = System.Drawing.Color.Black;
			this.NotificationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NotificationBox.CausesValidation = false;
			this.NotificationBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.NotificationBox.DetectUrls = false;
			this.NotificationBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.NotificationBox.ForeColor = System.Drawing.Color.White;
			this.NotificationBox.Location = new System.Drawing.Point(173, 51);
			this.NotificationBox.Name = "NotificationBox";
			this.NotificationBox.ReadOnly = true;
			this.NotificationBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.NotificationBox.ShortcutsEnabled = false;
			this.NotificationBox.Size = new System.Drawing.Size(480, 90);
			this.NotificationBox.TabIndex = 15;
			this.NotificationBox.TabStop = false;
			this.NotificationBox.Text = "";
			this.NotificationBox.WordWrap = false;
			// 
			// TimeLine
			// 
			this.TimeLine.AutoScroll = true;
			this.TimeLine.BackColor = System.Drawing.Color.Black;
			this.TimeLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TimeLine.ForeColor = System.Drawing.Color.White;
			this.TimeLine.Location = new System.Drawing.Point(100, 194);
			this.TimeLine.Name = "TimeLine";
			this.TimeLine.Size = new System.Drawing.Size(600, 307);
			this.TimeLine.TabIndex = 0;
			this.TimeLine.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.TimeLine_MouseWheel);
			// 
			// CursorRU
			// 
			this.CursorRU.BackColor = System.Drawing.Color.Transparent;
			this.CursorRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CursorRU.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorRU.Image = ((System.Drawing.Image)(resources.GetObject("CursorRU.Image")));
			this.CursorRU.Location = new System.Drawing.Point(743, 256);
			this.CursorRU.Name = "CursorRU";
			this.CursorRU.Size = new System.Drawing.Size(55, 35);
			this.CursorRU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CursorRU.TabIndex = 16;
			this.CursorRU.TabStop = false;
			this.CursorRU.Click += new System.EventHandler(this.CursorRU_Click);
			// 
			// CursorRD
			// 
			this.CursorRD.BackColor = System.Drawing.Color.Transparent;
			this.CursorRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CursorRD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorRD.Image = ((System.Drawing.Image)(resources.GetObject("CursorRD.Image")));
			this.CursorRD.Location = new System.Drawing.Point(743, 403);
			this.CursorRD.Name = "CursorRD";
			this.CursorRD.Size = new System.Drawing.Size(55, 35);
			this.CursorRD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CursorRD.TabIndex = 17;
			this.CursorRD.TabStop = false;
			this.CursorRD.Click += new System.EventHandler(this.CursorRD_Click);
			// 
			// CursorLD
			// 
			this.CursorLD.BackColor = System.Drawing.Color.Transparent;
			this.CursorLD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CursorLD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorLD.Image = ((System.Drawing.Image)(resources.GetObject("CursorLD.Image")));
			this.CursorLD.Location = new System.Drawing.Point(2, 465);
			this.CursorLD.Name = "CursorLD";
			this.CursorLD.Size = new System.Drawing.Size(55, 35);
			this.CursorLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CursorLD.TabIndex = 18;
			this.CursorLD.TabStop = false;
			this.CursorLD.Click += new System.EventHandler(this.CursorLD_Click);
			// 
			// CursorLU
			// 
			this.CursorLU.BackColor = System.Drawing.Color.Transparent;
			this.CursorLU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CursorLU.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorLU.Image = ((System.Drawing.Image)(resources.GetObject("CursorLU.Image")));
			this.CursorLU.Location = new System.Drawing.Point(2, 193);
			this.CursorLU.Name = "CursorLU";
			this.CursorLU.Size = new System.Drawing.Size(55, 35);
			this.CursorLU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CursorLU.TabIndex = 19;
			this.CursorLU.TabStop = false;
			this.CursorLU.Click += new System.EventHandler(this.CursorLU_Click);
			// 
			// DCursorRU
			// 
			this.DCursorRU.BackColor = System.Drawing.Color.Transparent;
			this.DCursorRU.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DCursorRU.Image = global::CHATTER.Properties.Resources.CursorDoubleUp;
			this.DCursorRU.Location = new System.Drawing.Point(743, 194);
			this.DCursorRU.Name = "DCursorRU";
			this.DCursorRU.Size = new System.Drawing.Size(55, 56);
			this.DCursorRU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DCursorRU.TabIndex = 20;
			this.DCursorRU.TabStop = false;
			this.DCursorRU.Click += new System.EventHandler(this.DCursorRU_Click);
			// 
			// DCursorRD
			// 
			this.DCursorRD.BackColor = System.Drawing.Color.Transparent;
			this.DCursorRD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DCursorRD.Image = global::CHATTER.Properties.Resources.CursorDoubleDown;
			this.DCursorRD.Location = new System.Drawing.Point(743, 444);
			this.DCursorRD.Name = "DCursorRD";
			this.DCursorRD.Size = new System.Drawing.Size(55, 56);
			this.DCursorRD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DCursorRD.TabIndex = 21;
			this.DCursorRD.TabStop = false;
			this.DCursorRD.Click += new System.EventHandler(this.DCursorRD_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Location = new System.Drawing.Point(101, 450);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Black;
			this.pictureBox2.Location = new System.Drawing.Point(207, 450);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 23;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Black;
			this.pictureBox4.Location = new System.Drawing.Point(419, 450);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 50);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 24;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Visible = false;
			this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Black;
			this.pictureBox3.Location = new System.Drawing.Point(313, 450);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 50);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 25;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Visible = false;
			this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
			// 
			// UploadImageMenu
			// 
			this.UploadImageMenu.BackColor = System.Drawing.Color.Black;
			this.UploadImageMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.UploadImageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cancel});
			this.UploadImageMenu.Name = "UploadImageMenu";
			this.UploadImageMenu.ShowImageMargin = false;
			this.UploadImageMenu.Size = new System.Drawing.Size(74, 26);
			this.UploadImageMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.UploadImageMenu_ItemClicked);
			// 
			// Cancel
			// 
			this.Cancel.ForeColor = System.Drawing.Color.White;
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(73, 22);
			this.Cancel.Text = "取消";
			// 
			// TitleLabelB
			// 
			this.TitleLabelB.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabelB.Font = new System.Drawing.Font("HGS明朝E", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TitleLabelB.ForeColor = System.Drawing.Color.White;
			this.TitleLabelB.Location = new System.Drawing.Point(77, 153);
			this.TitleLabelB.Name = "TitleLabelB";
			this.TitleLabelB.Size = new System.Drawing.Size(648, 25);
			this.TitleLabelB.TabIndex = 28;
			this.TitleLabelB.Text = "実況通神";
			this.TitleLabelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleLabelB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
			this.TitleLabelB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
			// 
			// CursorRightButtom
			// 
			this.CursorRightButtom.BackColor = System.Drawing.Color.Transparent;
			this.CursorRightButtom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorRightButtom.Image = global::CHATTER.Properties.Resources.CursorRight;
			this.CursorRightButtom.Location = new System.Drawing.Point(713, 506);
			this.CursorRightButtom.Name = "CursorRightButtom";
			this.CursorRightButtom.Size = new System.Drawing.Size(30, 54);
			this.CursorRightButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CursorRightButtom.TabIndex = 30;
			this.CursorRightButtom.TabStop = false;
			// 
			// CursorLeftButtom
			// 
			this.CursorLeftButtom.BackColor = System.Drawing.Color.Transparent;
			this.CursorLeftButtom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorLeftButtom.Image = global::CHATTER.Properties.Resources.CursorLeft;
			this.CursorLeftButtom.Location = new System.Drawing.Point(58, 506);
			this.CursorLeftButtom.Name = "CursorLeftButtom";
			this.CursorLeftButtom.Size = new System.Drawing.Size(30, 54);
			this.CursorLeftButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CursorLeftButtom.TabIndex = 29;
			this.CursorLeftButtom.TabStop = false;
			// 
			// CursorLeftTop
			// 
			this.CursorLeftTop.BackColor = System.Drawing.Color.Transparent;
			this.CursorLeftTop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorLeftTop.Image = global::CHATTER.Properties.Resources.CursorLeft;
			this.CursorLeftTop.Location = new System.Drawing.Point(12, 51);
			this.CursorLeftTop.Name = "CursorLeftTop";
			this.CursorLeftTop.Size = new System.Drawing.Size(30, 90);
			this.CursorLeftTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CursorLeftTop.TabIndex = 34;
			this.CursorLeftTop.TabStop = false;
			// 
			// CursorRightTop
			// 
			this.CursorRightTop.BackColor = System.Drawing.Color.Transparent;
			this.CursorRightTop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CursorRightTop.Image = global::CHATTER.Properties.Resources.CursorRight;
			this.CursorRightTop.Location = new System.Drawing.Point(758, 51);
			this.CursorRightTop.Name = "CursorRightTop";
			this.CursorRightTop.Size = new System.Drawing.Size(30, 90);
			this.CursorRightTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CursorRightTop.TabIndex = 33;
			this.CursorRightTop.TabStop = false;
			// 
			// Settings
			// 
			this.Settings.BackColor = System.Drawing.Color.Black;
			this.Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Settings.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Settings.Location = new System.Drawing.Point(659, 88);
			this.Settings.Name = "Settings";
			this.Settings.Size = new System.Drawing.Size(66, 23);
			this.Settings.TabIndex = 35;
			this.Settings.Text = "設定";
			this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Settings.Click += new System.EventHandler(this.Settings_Click);
			// 
			// MainFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.BackgroundImage = global::CHATTER.Properties.Resources.AsamaMain;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.Settings);
			this.Controls.Add(this.CursorLeftTop);
			this.Controls.Add(this.CursorRightTop);
			this.Controls.Add(this.CursorRightButtom);
			this.Controls.Add(this.CursorLeftButtom);
			this.Controls.Add(this.TitleLabelB);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.DCursorRD);
			this.Controls.Add(this.DCursorRU);
			this.Controls.Add(this.CursorLU);
			this.Controls.Add(this.CursorLD);
			this.Controls.Add(this.CursorRD);
			this.Controls.Add(this.CursorRU);
			this.Controls.Add(this.TimeLine);
			this.Controls.Add(this.NotificationBox);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.Reload_Button);
			this.Controls.Add(this.SmallizeButton);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.TitleLabelA);
			this.Controls.Add(this.myIcon);
			this.Controls.Add(this.TweetBox);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.White;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MainFrame";
			this.Opacity = 0.9D;
			this.Text = "実況通神";
			this.TransparencyKey = this.BackColor;
			this.Load += new System.EventHandler(this.MainFrame_Load);
			((System.ComponentModel.ISupportInitialize)(this.myIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallizeButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRU)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLU)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DCursorRU)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DCursorRD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.UploadImageMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CursorRightButtom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLeftButtom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorLeftTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorRightTop)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TweetBox;
		private System.Windows.Forms.PictureBox myIcon;
		private System.Windows.Forms.Label TitleLabelA;
		private System.Windows.Forms.PictureBox CloseButton;
		private System.Windows.Forms.PictureBox SmallizeButton;
		private System.Windows.Forms.Label Reload_Button;
		private System.Windows.Forms.Label SendButton;
		private System.Windows.Forms.RichTextBox NotificationBox;
		private System.Windows.Forms.FlowLayoutPanel TimeLine;
		private System.Windows.Forms.PictureBox CursorRU;
		private System.Windows.Forms.PictureBox CursorRD;
		private System.Windows.Forms.PictureBox CursorLD;
		private System.Windows.Forms.PictureBox CursorLU;
		private System.Windows.Forms.PictureBox DCursorRU;
		private System.Windows.Forms.PictureBox DCursorRD;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.ContextMenuStrip UploadImageMenu;
		private System.Windows.Forms.ToolStripMenuItem Cancel;
		private System.Windows.Forms.Label TitleLabelB;
		private System.Windows.Forms.PictureBox CursorRightButtom;
		private System.Windows.Forms.PictureBox CursorLeftButtom;
		private System.Windows.Forms.PictureBox CursorLeftTop;
		private System.Windows.Forms.PictureBox CursorRightTop;
		private System.Windows.Forms.Label Settings;
	}
}

