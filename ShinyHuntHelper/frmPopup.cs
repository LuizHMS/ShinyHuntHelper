using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyHuntHelper
{
    public partial class frmPopup : Form
    {
        private bool maxed = false;
        private int offsetWidth;
        private int offsetHeight;
        public frmPopup(string imgLink)
        {
            InitializeComponent();
            pcbPopUp.ImageLocation = imgLink;
            offsetWidth = pcbPopUp.Width - this.Width;
            offsetHeight = pcbPopUp.Height - this.Height;

        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            if (clrBackground.ShowDialog() == DialogResult.OK)
            {
                pcbPopUp.BackColor = clrBackground.Color;
            }
        }

        private void pcbPopUp_DoubleClick(object sender, EventArgs e)
        {
            maxed = !maxed;
            if (maxed)
            {
                pcbPopUp.Dock = DockStyle.Fill;
                btnColorDialog.Hide();
            }
            else
            {
                
                pcbPopUp.Dock = DockStyle.None;
                pcbPopUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                pcbPopUp.Height = this.Height + offsetHeight;
                pcbPopUp.Width = this.Width + offsetWidth;
                btnColorDialog.Show();
            }
            
        }

        private void pcbPopUp_Click(object sender, EventArgs e)
        {

        }

    }
}
