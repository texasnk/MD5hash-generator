using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace HashMD5
{
    internal class MD5
    {
        public string returnMD5(string pass)
        {
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                return returnHash(md5Hash, pass);
            }
        }

        public bool CompareMD5(string passUser, string passMD5)
        {
            string pass = returnMD5(passUser);
            if (VerifyHash(passMD5, pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string returnHash(System.Security.Cryptography.MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder= new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }

            return sBuilder.ToString();
        }

        private bool VerifyHash(string input, string hash)
        {
            StringComparer compare = StringComparer.OrdinalIgnoreCase;
            if (compare.Compare(input,hash)==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
