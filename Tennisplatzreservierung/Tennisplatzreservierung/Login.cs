using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennisplatzreservierung
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_register_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.ShowDialog();
        }
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();  //or use SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }

        public static string GernerateSalt()
        {
            byte[] salt = new byte[32];
            RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();
            random.GetNonZeroBytes(salt);
            return Convert.ToBase64String(salt);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tbx_login_email.Text != string.Empty && mtbx_login_password.Text != string.Empty)
            {
                ConnectionClass connectionClass = new ConnectionClass();
                OdbcConnection Connection = connectionClass.GetConnection();

                string sql = string.Format("select Password from tab_user where EMail='{0}'", tbx_login_email.Text);
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                Connection.Open();
                string actualpassword = Convert.ToString(cmd.ExecuteScalar());
                Connection.Close();

                sql = string.Format("select Salt from tab_user where EMail='{0}'", tbx_login_email.Text);
                cmd = new OdbcCommand(sql, Connection);
                Connection.Open();
                string salt = Convert.ToString(cmd.ExecuteScalar());
                Connection.Close();

                string sourcepassword = GetHashString(mtbx_login_password.Text + salt);




                if (string.Compare(actualpassword, sourcepassword) == 0)
                {
                    lbl_output.Text = ("Login erfolgreich!");
                }
                else
                {
                    lbl_output.Text = ("Falsche E-Mail oder Passwort!");
                }
            }
            else
            {
                lbl_output.Text = "Bitte geben sie EMail und Passwort ein";
            }

        }
    }
}
