using CoreTweet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuartzTypeLib;
using System.IO;

namespace CHATTER
{
	public partial class ImageFrame : BaseFrame
	{
		private MediaEntity mediaEntity = null;
		private bool pause;
		private string imageUrl = null;

		public ImageFrame(MediaEntity mediaEntity)
		{
			InitializeComponent();

			this.mediaEntity = mediaEntity;
			pause = false;
		}

		public ImageFrame(string imageUrl)
		{
			InitializeComponent();

			this.imageUrl = imageUrl;
			pause = false;
		}

		private void ImageFrame_Load(object sender, EventArgs e)
		{
			Opacity = 1;
			if (mediaEntity != null)
			{
				int h = mediaEntity.Sizes.Large.Height;
				int w = mediaEntity.Sizes.Large.Width;

				// 画像サイズに合わせて比率を調整
				if (mediaEntity.Sizes.Large.Height > MaximumSize.Height)
				{
					double rate = (double)MaximumSize.Height / (double)mediaEntity.Sizes.Large.Height;
					w = (int)(mediaEntity.Sizes.Large.Width * rate);
					h = MaximumSize.Height;
				}

				if (mediaEntity.Sizes.Large.Width > MaximumSize.Width)
				{
					double rate = (double)MaximumSize.Width / (double)mediaEntity.Sizes.Large.Width;
					h = (int)(mediaEntity.Sizes.Large.Height * rate);
					w = MaximumSize.Width;
				}

				if (mediaEntity.Type == "animated_gif")
				{
					VideoPlayer.Size = new Size(w, h);

					VideoPlayer.uiMode = "none";
					VideoPlayer.settings.setMode("loop", true);
					VideoPlayer.URL = mediaEntity.VideoInfo.Variants[0].Url;
				}
				else if (mediaEntity.Type == "video")
				{
					VideoPlayer.Size = new Size(w, h);

					VideoPlayer.uiMode = "none";
					VideoPlayer.settings.setMode("loop", true);

					for (int i = 0; i < mediaEntity.VideoInfo.Variants.Length; i++)
					{
						if (mediaEntity.VideoInfo.Variants[i].ContentType == "video/mp4")
						{
							VideoPlayer.URL = mediaEntity.VideoInfo.Variants[i].Url;
							break;
						}
					}
				}
				else
				{
					Controls.Remove(VideoPlayer);

					pictureBox.Size = new Size(w, h);

					pictureBox.ImageLocation = mediaEntity.MediaUrl + ":large";
					pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				}
			}
			else if (imageUrl != null)
			{
				Controls.Remove(VideoPlayer);
				pictureBox.ImageLocation = imageUrl;
				pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}

		private void Close_Button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Smallize_Button_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void VideoPlayer_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
		{
			if (pause)
			{
				VideoPlayer.Ctlcontrols.play();
				pause = false;
			}
			else
			{
				VideoPlayer.Ctlcontrols.pause();
				pause = true;
			}
		}

		private void ImageFrame_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void pictureBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				SaveMenu.Show(this, PointToClient(Cursor.Position));
			}
		}

		private void SaveMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.Text == "保存")
			{
				SaveMenu.Close();
				SaveImageDialog.FileName = Path.GetFileNameWithoutExtension(mediaEntity.MediaUrl);
				SaveImageDialog.Filter = "JPEG形式|*.jpg;*.jpeg|PNG形式|*.png|GIF形式|*.gif";
				//SaveImageDialog.Filter = Path.GetExtension(mediaEntity.MediaUrl);
				SaveImageDialog.ShowDialog();
				Console.WriteLine("保存");
			}
		}

		private void SaveImageDialog_FileOk(object sender, CancelEventArgs e)
		{
			string extension = Path.GetExtension(SaveImageDialog.FileName);
			//string extension = System.IO.Path.GetExtension(pictureBox.ImageLocation);

			switch (extension.ToLower())
			{
				case ".gif":
					pictureBox.Image.Save(SaveImageDialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
					break;
				case ".jpg":
					pictureBox.Image.Save(SaveImageDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
					break;
				case ".png":
					pictureBox.Image.Save(SaveImageDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
					break;
				default:
					break;
			}
		}

		private void LeftCursor_Click(object sender, EventArgs e)
		{

		}

		private void RightCursor_Click(object sender, EventArgs e)
		{

		}
	}
}
