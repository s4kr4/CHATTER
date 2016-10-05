using System;
using System.Drawing;
using System.Windows.Forms;

namespace CHATTER
{
	public partial class BaseFrame : Form
	{
		private double tmpOpacity;

		public Point mousePoint;
		private Size formSize;

		private int margin;

		private System.Media.SoundPlayer player;

		private enum MoveOrSize
		{
			None,
			Move,
			Size
		}

		private MoveOrSize flag;

		private enum ResizeDirection
		{
			None = 0,
			Top = 1,
			Left = 2,
			Right = 4,
			Bottom = 8,
			All = 15
		}

		private ResizeDirection resizeStatus;

		Rectangle topRect;
		Rectangle leftRect;
		Rectangle rightRect;
		Rectangle bottomRect;

		public BaseFrame()
		{
			InitializeComponent();

			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.StandardDoubleClick, false);
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);

			tmpOpacity = 0.9D;
			margin = 10;

			flag = MoveOrSize.None;

			topRect = new Rectangle(0, 0, this.Width, margin);
			leftRect = new Rectangle(0, 0, margin, this.Height);
			rightRect = new Rectangle(this.Width - margin, 0, margin, this.Height);
			bottomRect = new Rectangle(0, this.Height - margin, this.Width, this.Height);

			resizeStatus = ResizeDirection.None;

			player = new System.Media.SoundPlayer(Properties.Resources.open);
		}

		private void BaseFrame_Load(object sender, EventArgs e)
		{
			player.Play();
		}

		//ドラッグでフォーム位置移動
		public void Frame_MouseDown(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				// ドラッグ移動有効範囲
				Rectangle moveArea = new Rectangle(
					margin, margin, this.Width - (margin * 2), this.Height - (margin * 2));

				formSize = this.Size;
				mousePoint = e.Location;

				if (moveArea.Contains(e.Location))
				{
					flag = MoveOrSize.Move;
					Capture = true;
				}
				else
				{
					Capture = true;
					flag = MoveOrSize.Size;
					topRect = new Rectangle(0, 0, this.Width, margin);
					leftRect = new Rectangle(0, 0, margin, this.Height);
					rightRect = new Rectangle(this.Width - margin, 0, margin, this.Height);
					bottomRect = new Rectangle(0, this.Height - margin, this.Width, this.Height);

					if (topRect.Contains(e.Location))
					{
						resizeStatus |= ResizeDirection.Top;
					}
					if (leftRect.Contains(e.Location))
					{
						resizeStatus |= ResizeDirection.Left;
					}
					if (rightRect.Contains(e.Location))
					{
						resizeStatus |= ResizeDirection.Right;
					}
					if (bottomRect.Contains(e.Location))
					{
						resizeStatus |= ResizeDirection.Bottom;
					}
				}
			}
		}

		public void Frame_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				if (flag == MoveOrSize.Move)
				{
					this.Left += e.X - mousePoint.X;
					this.Top += e.Y - mousePoint.Y;
				}
				else if (flag == MoveOrSize.Size)
				{
					int diffX = e.X - mousePoint.X;
					int diffY = e.Y - mousePoint.Y;

					//this.SuspendLayout();
					if ((resizeStatus & ResizeDirection.Top) == ResizeDirection.Top)
					{
						int h = this.Height;
						this.Height -= diffY;
						this.Top += h - this.Height;
					}
					if ((resizeStatus & ResizeDirection.Left) == ResizeDirection.Left)
					{
						int w = this.Width;
						this.Width -= diffX;
						this.Left += w - this.Width;
					}
					if ((resizeStatus & ResizeDirection.Right) == ResizeDirection.Right)
					{
						this.Width = formSize.Width + diffX;
					}
					if ((resizeStatus & ResizeDirection.Bottom) == ResizeDirection.Bottom)
					{
						this.Height = formSize.Height + diffY;
					}
					//this.ResumeLayout();
				}
			}
		}

		private void BaseFrame_MouseUp(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				flag = MoveOrSize.None;
				Capture = false;
			}
		}

		//Ctrl + W → 閉じる
		//Ctrl + Shift + 方向 → 動かす
		public void Frame_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.W) & e.Control) this.Close();
			if ((e.KeyCode == Keys.Up) & e.Control & e.Shift) this.Top -= 10;
			if ((e.KeyCode == Keys.Down) & e.Control & e.Shift) this.Top += 10;
			if ((e.KeyCode == Keys.Left) & e.Control & e.Shift) this.Left -= 10;
			if ((e.KeyCode == Keys.Right) & e.Control & e.Shift) this.Left += 10;
			if ((e.KeyCode == Keys.Up) & e.Shift & e.Alt)
			{
				if (this.Opacity < 1.0D)
				{
					this.Opacity += 0.1D;
				}
			}
			if ((e.KeyCode == Keys.Down) & e.Shift & e.Alt)
			{
				if (this.Opacity > 0.2D)
				{
					this.Opacity -= 0.1D;
				}
			}
		}

		private void BaseFrame_Activated(object sender, EventArgs e)
		{
			this.Opacity = tmpOpacity;
		}

		private void BaseFrame_Deactivate(object sender, EventArgs e)
		{
			tmpOpacity = this.Opacity;
			//if (this.Opacity > 0.5D) this.Opacity = 0.5D;
		}

		private void BaseFrame_ResizeBegin(object sender, EventArgs e)
		{
			this.SuspendLayout();
		}

		private void BaseFrame_ResizeEnd(object sender, EventArgs e)
		{
			this.ResumeLayout();
		}
	}
}
