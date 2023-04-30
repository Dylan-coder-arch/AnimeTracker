using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeTracker
{
    public partial class Form1 : KryptonForm
    {

        public static string userID;
        public static string refUserName;
        public Form1()
        {
            InitializeComponent();
            
            

        }

        private void kbtnLogin_Click(object sender, EventArgs e)
        {
           

            string server = "127.0.0.1";
            string port = "3306";
            string db = "AnimeTrackingSystem";
            string username = "root";
            string password = "77P]u7h-Gb-Q'*8*";
            string constring = $"SERVER={server};PORT={port};DATABASE={db};UID={username};PASSWORD={password};";
            string query = "";


            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string userName = ktbxUsername.Text;
            string userPassword = ktbxPassword.Text;
            
            query = $"SELECT usrID, usrName, usrEmail, usrPassword FROM USERS WHERE usrEmail = @usrNameParam AND usrPassword = @passwordParam";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@usrNameParam", userName);
            cmd.Parameters.AddWithValue("@passwordParam", userPassword);
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);

            MySqlDataReader reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {   
                userID = reader.GetValue(0).ToString();
                refUserName = reader.GetValue(1).ToString();
            }

            
            if (userID == null)
            {
                MessageBox.Show("Invalid details! please try again!");
                return;
            }

            
            reader.Close();
            cmd.Dispose();
            conn.Close();
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
        }

        private void kbtnSignup_Click(object sender, EventArgs e)
        {
            
            frmSignup signupForm = new frmSignup();
            signupForm.ShowDialog();
        }
    }
}
