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
    public partial class uctAdd : UserControl
    {
        public uctAdd()
        {
            InitializeComponent();
        }

        private void uctAdd_Load(object sender, EventArgs e)
        {
            ktxbName.Focus();
        }

        private void kbtnAdd_Click(object sender, EventArgs e)
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

            
            int usrID = Convert.ToInt32(Form1.userID);
            string animeName = ktxbName.Text;
            decimal animeRating = knudRating.Value;
            DateTime startDate = kdtpStartDate.Value;
            DateTime endDate = kdtpEndDate.Value;
            
            
            
            query = $"INSERT INTO ANIME(usrID, animeName, startDate, endDate, rating) VALUES (@usrIDParam, @animeNameParam, @startDateParam, @endDateParam, @animeRatingParam);";
            
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@usrIDParam", usrID);
            cmd.Parameters.AddWithValue("@animeNameParam", animeName);
            cmd.Parameters.AddWithValue("@startDateParam", startDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@endDateParam", endDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@animeRatingParam", animeRating);
            cmd.ExecuteNonQuery();
            conn.Close();

            // Clear all the components values back to the defaults 
            ktxbName.Text = "";
            knudRating.Value = 0;
            kdtpStartDate.Value = DateTime.Now;
            kdtpEndDate.Value = DateTime.Now;
        }

    }
}
