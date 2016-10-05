namespace CHATTER
{
    partial class TweetItem
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweetItem));
			this.NameLabel = new System.Windows.Forms.Label();
			this.ActionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.会話を表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TweetTextLabel = new System.Windows.Forms.Label();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.MyActionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.通神帯接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.会話を表示ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.削除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.retweetUserName = new System.Windows.Forms.Label();
			this.StartButton = new System.Windows.Forms.PictureBox();
			this.retweetUserIcon = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ReplyIcon = new System.Windows.Forms.PictureBox();
			this.RetweetIcon = new System.Windows.Forms.PictureBox();
			this.FavoriteIcon = new System.Windows.Forms.PictureBox();
			this.IconFrame = new System.Windows.Forms.PictureBox();
			this.ActionMenu.SuspendLayout();
			this.MyActionMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.retweetUserIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ReplyIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RetweetIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FavoriteIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IconFrame)).BeginInit();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NameLabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
			this.NameLabel.Location = new System.Drawing.Point(59, 6);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(42, 15);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "Name";
			this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
			// 
			// ActionMenu
			// 
			this.ActionMenu.BackColor = System.Drawing.Color.Black;
			this.ActionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ActionMenu.ForeColor = System.Drawing.Color.White;
			this.ActionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openURLToolStripMenuItem,
            this.会話を表示ToolStripMenuItem});
			this.ActionMenu.Name = "contextMenuStrip1";
			this.ActionMenu.ShowImageMargin = false;
			this.ActionMenu.Size = new System.Drawing.Size(110, 48);
			this.ActionMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ActionMenu_ItemClicked);
			// 
			// openURLToolStripMenuItem
			// 
			this.openURLToolStripMenuItem.Name = "openURLToolStripMenuItem";
			this.openURLToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.openURLToolStripMenuItem.Text = "通神帯接続";
			// 
			// 会話を表示ToolStripMenuItem
			// 
			this.会話を表示ToolStripMenuItem.Name = "会話を表示ToolStripMenuItem";
			this.会話を表示ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.会話を表示ToolStripMenuItem.Text = "会話を表示";
			// 
			// TweetTextLabel
			// 
			this.TweetTextLabel.AutoSize = true;
			this.TweetTextLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TweetTextLabel.ForeColor = System.Drawing.Color.White;
			this.TweetTextLabel.Location = new System.Drawing.Point(59, 21);
			this.TweetTextLabel.MaximumSize = new System.Drawing.Size(420, 500);
			this.TweetTextLabel.MinimumSize = new System.Drawing.Size(420, 15);
			this.TweetTextLabel.Name = "TweetTextLabel";
			this.TweetTextLabel.Size = new System.Drawing.Size(420, 18);
			this.TweetTextLabel.TabIndex = 4;
			this.TweetTextLabel.Text = "Text";
			this.TweetTextLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyTweetLabel_MouseClick);
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TimeLabel.Location = new System.Drawing.Point(59, 42);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(34, 14);
			this.TimeLabel.TabIndex = 5;
			this.TimeLabel.Text = "Time";
			// 
			// MyActionMenu
			// 
			this.MyActionMenu.BackColor = System.Drawing.Color.Black;
			this.MyActionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.MyActionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通神帯接続ToolStripMenuItem,
            this.会話を表示ToolStripMenuItem1,
            this.削除ToolStripMenuItem1});
			this.MyActionMenu.Name = "MyActionMenu";
			this.MyActionMenu.ShowImageMargin = false;
			this.MyActionMenu.Size = new System.Drawing.Size(110, 70);
			this.MyActionMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ActionMenu_ItemClicked);
			// 
			// 通神帯接続ToolStripMenuItem
			// 
			this.通神帯接続ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.通神帯接続ToolStripMenuItem.Name = "通神帯接続ToolStripMenuItem";
			this.通神帯接続ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.通神帯接続ToolStripMenuItem.Text = "通神帯接続";
			// 
			// 会話を表示ToolStripMenuItem1
			// 
			this.会話を表示ToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.会話を表示ToolStripMenuItem1.Name = "会話を表示ToolStripMenuItem1";
			this.会話を表示ToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
			this.会話を表示ToolStripMenuItem1.Text = "会話を表示";
			// 
			// 削除ToolStripMenuItem1
			// 
			this.削除ToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.削除ToolStripMenuItem1.Name = "削除ToolStripMenuItem1";
			this.削除ToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
			this.削除ToolStripMenuItem1.Text = "削除";
			// 
			// retweetUserName
			// 
			this.retweetUserName.AutoSize = true;
			this.retweetUserName.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.retweetUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
			this.retweetUserName.Location = new System.Drawing.Point(40, 246);
			this.retweetUserName.Name = "retweetUserName";
			this.retweetUserName.Size = new System.Drawing.Size(42, 15);
			this.retweetUserName.TabIndex = 14;
			this.retweetUserName.Text = "Name";
			// 
			// StartButton
			// 
			this.StartButton.BackColor = System.Drawing.Color.Transparent;
			this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.StartButton.Image = global::CHATTER.Properties.Resources.start;
			this.StartButton.Location = new System.Drawing.Point(110, 71);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(50, 50);
			this.StartButton.TabIndex = 15;
			this.StartButton.TabStop = false;
			this.StartButton.Visible = false;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// retweetUserIcon
			// 
			this.retweetUserIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.retweetUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("retweetUserIcon.Image")));
			this.retweetUserIcon.Location = new System.Drawing.Point(3, 228);
			this.retweetUserIcon.Name = "retweetUserIcon";
			this.retweetUserIcon.Size = new System.Drawing.Size(30, 30);
			this.retweetUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.retweetUserIcon.TabIndex = 13;
			this.retweetUserIcon.TabStop = false;
			this.retweetUserIcon.Click += new System.EventHandler(this.retweetUserIcon_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox4.Image = global::CHATTER.Properties.Resources.retweet_a;
			this.pictureBox4.Location = new System.Drawing.Point(216, 142);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(150, 80);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 12;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.PictureBox_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = global::CHATTER.Properties.Resources.retweet_a;
			this.pictureBox3.Location = new System.Drawing.Point(60, 142);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(150, 80);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.PictureBox_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::CHATTER.Properties.Resources.retweet_a;
			this.pictureBox2.Location = new System.Drawing.Point(216, 56);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(150, 80);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::CHATTER.Properties.Resources.retweet_a;
			this.pictureBox1.Location = new System.Drawing.Point(60, 56);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 80);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox_Click);
			// 
			// ReplyIcon
			// 
			this.ReplyIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ReplyIcon.Image = global::CHATTER.Properties.Resources.reply_a;
			this.ReplyIcon.Location = new System.Drawing.Point(500, 18);
			this.ReplyIcon.Name = "ReplyIcon";
			this.ReplyIcon.Size = new System.Drawing.Size(20, 20);
			this.ReplyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ReplyIcon.TabIndex = 8;
			this.ReplyIcon.TabStop = false;
			this.ReplyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReplyIcon_MouseClick);
			this.ReplyIcon.MouseEnter += new System.EventHandler(this.ReplyIcon_MouseEnter);
			this.ReplyIcon.MouseLeave += new System.EventHandler(this.ReplyIcon_MouseLeave);
			// 
			// RetweetIcon
			// 
			this.RetweetIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RetweetIcon.Image = global::CHATTER.Properties.Resources.retweet_a;
			this.RetweetIcon.Location = new System.Drawing.Point(526, 18);
			this.RetweetIcon.Name = "RetweetIcon";
			this.RetweetIcon.Size = new System.Drawing.Size(20, 20);
			this.RetweetIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.RetweetIcon.TabIndex = 7;
			this.RetweetIcon.TabStop = false;
			this.RetweetIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RetweetIcon_MouseClick);
			this.RetweetIcon.MouseEnter += new System.EventHandler(this.RetweetIcon_MouseEnter);
			this.RetweetIcon.MouseLeave += new System.EventHandler(this.RetweetIcon_MouseLeave);
			// 
			// FavoriteIcon
			// 
			this.FavoriteIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FavoriteIcon.Image = global::CHATTER.Properties.Resources.favorite_a;
			this.FavoriteIcon.Location = new System.Drawing.Point(552, 18);
			this.FavoriteIcon.Name = "FavoriteIcon";
			this.FavoriteIcon.Size = new System.Drawing.Size(20, 20);
			this.FavoriteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FavoriteIcon.TabIndex = 6;
			this.FavoriteIcon.TabStop = false;
			this.FavoriteIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FavoriteIcon_MouseClick);
			this.FavoriteIcon.MouseEnter += new System.EventHandler(this.FavoriteIcon_MouseEnter);
			this.FavoriteIcon.MouseLeave += new System.EventHandler(this.FavoriteIcon_MouseLeave);
			// 
			// IconFrame
			// 
			this.IconFrame.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IconFrame.Image = ((System.Drawing.Image)(resources.GetObject("IconFrame.Image")));
			this.IconFrame.Location = new System.Drawing.Point(3, 3);
			this.IconFrame.Name = "IconFrame";
			this.IconFrame.Size = new System.Drawing.Size(50, 50);
			this.IconFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.IconFrame.TabIndex = 0;
			this.IconFrame.TabStop = false;
			this.IconFrame.Click += new System.EventHandler(this.IconFrame_Click);
			// 
			// TweetItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.retweetUserName);
			this.Controls.Add(this.retweetUserIcon);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ReplyIcon);
			this.Controls.Add(this.RetweetIcon);
			this.Controls.Add(this.FavoriteIcon);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.TweetTextLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.IconFrame);
			this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.MaximumSize = new System.Drawing.Size(575, 5000);
			this.Name = "TweetItem";
			this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.Size = new System.Drawing.Size(575, 264);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyTweetLabel_MouseClick);
			this.ActionMenu.ResumeLayout(false);
			this.MyActionMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.retweetUserIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ReplyIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RetweetIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FavoriteIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IconFrame)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconFrame;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ContextMenuStrip ActionMenu;
        private System.Windows.Forms.ToolStripMenuItem openURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会話を表示ToolStripMenuItem;
        private System.Windows.Forms.Label TweetTextLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.PictureBox FavoriteIcon;
        private System.Windows.Forms.PictureBox RetweetIcon;
        private System.Windows.Forms.PictureBox ReplyIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip MyActionMenu;
        private System.Windows.Forms.ToolStripMenuItem 通神帯接続ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会話を表示ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox retweetUserIcon;
		private System.Windows.Forms.Label retweetUserName;
		private System.Windows.Forms.PictureBox StartButton;
	}
}
