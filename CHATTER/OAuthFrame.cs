using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHATTER
{
    public partial class OAuthFrame : BaseFrame
    {
        public string pin { get; set; }

        public OAuthFrame()
        {
            InitializeComponent();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            this.pin = this.PINBox.Text;
            this.Close();
        }

        private void PINBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.pin = this.PINBox.Text;
                this.Close();
            }
        }
    }
}
