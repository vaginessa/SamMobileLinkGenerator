using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SamMobileLinkGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (txtUS.Text == string.Empty || txtPS.Text==string.Empty)
            {
                MessageBox.Show("UserName or Password is Empty!");
            }else if (txtDL.Text == string.Empty)
            {
                MessageBox.Show("Download Link is Empty!");
            }
            else
            {
                var _fixdl1 = txtDL.Text.Replace("https://", "");
                var _fixdl2 = _fixdl1.Replace("http://", "");
                txtGen.Text = "http://" + txtUS.Text + ":" + txtPS.Text + "@" + "www." + _fixdl2;
            }
           
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtGen.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thirteenForm1.Text += "   " + ProductVersion;
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ghost1372/SamMobileLinkGenerator");
        }
    }
}
