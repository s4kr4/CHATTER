namespace CHATTER
{
	partial class BaseFrame
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
			this.SuspendLayout();
			// 
			// BaseFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 300);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BaseFrame";
			this.Text = "Form1";
			this.Activated += new System.EventHandler(this.BaseFrame_Activated);
			this.Deactivate += new System.EventHandler(this.BaseFrame_Deactivate);
			this.Load += new System.EventHandler(this.BaseFrame_Load);
			this.ResizeBegin += new System.EventHandler(this.BaseFrame_ResizeBegin);
			this.ResizeEnd += new System.EventHandler(this.BaseFrame_ResizeEnd);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frame_KeyDown);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frame_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frame_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseFrame_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion
	}
}

