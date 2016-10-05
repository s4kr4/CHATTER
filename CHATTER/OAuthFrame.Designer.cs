namespace CHATTER
{
	partial class OAuthFrame
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
			this.PINBox = new System.Windows.Forms.TextBox();
			this.Confirm_Button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PINBox
			// 
			this.PINBox.Font = new System.Drawing.Font("Meiryo UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.PINBox.Location = new System.Drawing.Point(20, 24);
			this.PINBox.Name = "PINBox";
			this.PINBox.Size = new System.Drawing.Size(200, 52);
			this.PINBox.TabIndex = 0;
			this.PINBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PINBox_KeyDown);
			// 
			// Confirm_Button
			// 
			this.Confirm_Button.Font = new System.Drawing.Font("Meiryo UI", 10F);
			this.Confirm_Button.Location = new System.Drawing.Point(226, 24);
			this.Confirm_Button.Name = "Confirm_Button";
			this.Confirm_Button.Size = new System.Drawing.Size(52, 52);
			this.Confirm_Button.TabIndex = 1;
			this.Confirm_Button.Text = "認証";
			this.Confirm_Button.UseVisualStyleBackColor = true;
			this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
			// 
			// OAuthFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(300, 100);
			this.Controls.Add(this.Confirm_Button);
			this.Controls.Add(this.PINBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OAuthFrame";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "OAuthFrame";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PINBox;
		private System.Windows.Forms.Button Confirm_Button;
	}
}