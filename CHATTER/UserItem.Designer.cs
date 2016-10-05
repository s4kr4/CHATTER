namespace CHATTER
{
	partial class UserItem
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
			this.NameLabel = new System.Windows.Forms.Label();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.IconFrame = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.IconFrame)).BeginInit();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NameLabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
			this.NameLabel.Location = new System.Drawing.Point(59, 3);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(42, 15);
			this.NameLabel.TabIndex = 2;
			this.NameLabel.Text = "Name";
			this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Font = new System.Drawing.Font("Meiryo UI", 9F);
			this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
			this.DescriptionLabel.Location = new System.Drawing.Point(59, 18);
			this.DescriptionLabel.MaximumSize = new System.Drawing.Size(180, 500);
			this.DescriptionLabel.MinimumSize = new System.Drawing.Size(180, 15);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(180, 15);
			this.DescriptionLabel.TabIndex = 5;
			this.DescriptionLabel.Text = "Text";
			// 
			// IconFrame
			// 
			this.IconFrame.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IconFrame.Image = global::CHATTER.Properties.Resources.retweet_a;
			this.IconFrame.Location = new System.Drawing.Point(3, 3);
			this.IconFrame.Name = "IconFrame";
			this.IconFrame.Size = new System.Drawing.Size(50, 50);
			this.IconFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.IconFrame.TabIndex = 1;
			this.IconFrame.TabStop = false;
			this.IconFrame.Click += new System.EventHandler(this.IconFrame_Click);
			// 
			// UserItem
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.DescriptionLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.IconFrame);
			this.MaximumSize = new System.Drawing.Size(245, 500);
			this.MinimumSize = new System.Drawing.Size(245, 50);
			this.Name = "UserItem";
			this.Size = new System.Drawing.Size(245, 56);
			((System.ComponentModel.ISupportInitialize)(this.IconFrame)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox IconFrame;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label DescriptionLabel;
	}
}
