using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HashMD5
{
    public partial class FormHash : Form
    {
        public FormHash()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5();
            lblOutput.Text = md5.returnMD5(txtInput.Text);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string passData = "8E6F6F815B50F474CF0DC22D4F400725";
            string pass = txtInput.Text;

            MD5 md5 = new MD5();
            bool res = md5.CompareMD5(pass, passData);

            if (res)
            {
                lblOutput.Text = "Same passwords";
            }
            else
            {
                lblOutput.Text = "Different passwords";
            }

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblOutput.Text);            
            btnCopy.Text = "Copied!";
            btnCopy.Enabled = false;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnCopy.Text = "Copy";
            btnCopy.Enabled = true;

        }
    }
}
