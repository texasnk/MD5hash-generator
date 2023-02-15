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
            txtOutput.Text = md5.returnMD5(txtInput.Text);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string passData = "8E6F6F815B50F474CF0DC22D4F400725";
            string pass = txtInput.Text;

            MD5 md5 = new MD5();
            bool res = md5.CompareMD5(pass, passData);

            if (res)
            {
                lblResult.Text = "Same passwords";
            }
            else
            {
                lblResult.Text = "Different passwords";
            }

        }

    }
}
