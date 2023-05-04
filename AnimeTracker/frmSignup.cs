using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeTracker
{
    
    public partial class frmSignup : KryptonForm
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        

        private void kbtnSignup_Click(object sender, EventArgs e)
        {

            string email = ktbxEmail.Text;
            string password = ktbxPassword.Text;
            string confPass = ktbxConfirmPass.Text;
            string name = ktbxName.Text;

            if (email != null && password != null && confPass != null && name != null) 
            {
                if (!(email.Contains("@")))
                {
                    MessageBox.Show("Please enter a valid email");
                    return;
                }

                if (check_password(password)) 
                {
                    
                    string server = "127.0.0.1";
                    string port = "3306";
                    string db = "AnimeTrackingSystem";
                    string username = "root";
                    string dbPassword = "77P]u7h-Gb-Q'*8*";
                    string constring = $"SERVER={server};PORT={port};DATABASE={db};UID={username};PASSWORD={dbPassword};";
                    string query = "";
                    MySqlConnection conn = new MySqlConnection(constring);
                    conn.Open();

                    // method to create a salted password 
                    string salt = CreateSalt(64);
                    string hashedPassword = HashedPassword(password, salt);

                    query = $"INSERT INTO USERS(usrName, usrEmail, usrPassword, usrSalt) VALUES (@usrNameParam, @usrEmailParam, @usrPassParam, @usrSaltParam)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usrNameParam", name);
                    cmd.Parameters.AddWithValue("@usrEmailParam", email);
                    cmd.Parameters.AddWithValue("@usrPassParam", hashedPassword);
                    cmd.Parameters.AddWithValue("@usrSaltParam", salt);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sign up completed, please log in!");
                    this.Close();
                    return;
                }
                

            }
            MessageBox.Show("Please ensure that all fields have a value!");
            return;
        }

        private bool check_password(string pwd)
        {
            if (pwd.Length < 8) 
            {
                MessageBox.Show("Please ensure your password is at least 8 characters long");
                
                return false;
            }

            int amountCapital = 0;
            int amountDigit = 0;
            int specialChar = 0;

            foreach (char c in pwd)
            {
                if (char.IsUpper(c))
                {
                    amountCapital++;
                }

                if (char.IsDigit(c))
                {
                    amountDigit++;
                }

                if (!char.IsLetterOrDigit(c))
                {
                    
                    specialChar++;
                }

            }

            if ((amountCapital > 0) && (amountDigit > 0) && (specialChar > 0))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please ensure your password has at least:\n1 Capital Letter, 1 Digit and 1 Special Character");

                return false;
            }

        }
        public string CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        
        public string HashedPassword(string clear_pass, string salt)
        {

            byte[] bytes = UTF8Encoding.UTF8.GetBytes(clear_pass + salt);
            SHA256Managed sHA256Password = new SHA256Managed();

            byte[] hash = sHA256Password.ComputeHash(bytes);

            return Convert.ToBase64String(hash);

        }

    }

    
}
