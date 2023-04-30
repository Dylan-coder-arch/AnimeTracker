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
    public partial class uctHome : UserControl
    {
        public uctHome()
        {
            InitializeComponent();
        }

        private void uctHome_Load(object sender, EventArgs e)
        {
            

            string server = "127.0.0.1";
            string port = "3306";
            string db = "AnimeTrackingSystem";
            string username = "root";
            string password = "77P]u7h-Gb-Q'*8*";
            string constring = $"SERVER={server};PORT={port};DATABASE={db};UID={username};PASSWORD={password};";
            string query = $"SELECT COUNT(animeID) FROM ANIME, USERS WHERE ANIME.usrID = @usrIDParam";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@usrIDParam", Form1.userID);
            long amtTracked = (long) cmd.ExecuteScalar();
            conn.Close();

            
            klblWelcomeUser.Text = $"Hello, {Form1.refUserName}!";
            lblAmount.Text = amtTracked.ToString() + " anime!";
            
            

        }
    }
}
