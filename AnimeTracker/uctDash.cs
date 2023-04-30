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
    public partial class uctDash : UserControl
    {
        private static string server = "127.0.0.1";
        private static string port = "3306";
        private static string db = "AnimeTrackingSystem";
        private static string username = "root";
        private static string password = "77P]u7h-Gb-Q'*8*";
        private static string constring = $"SERVER={server};PORT={port};DATABASE={db};UID={username};PASSWORD={password};";
        private static string query = "";
        private MySqlConnection conn = new MySqlConnection(constring);
        public uctDash()
        {
            InitializeComponent();
            
        }

        private void uctDash_Load(object sender, EventArgs e)
        {

            query = "SELECT animeName, startDate, endDate, rating FROM ANIME";
            
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds, "ANIME");
            kdgvAnime.DataSource = ds.Tables["ANIME"].DefaultView;
            kdgvAnime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kdgvAnime.AutoResizeColumns();
        }

        private void ktbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = ktbxSearch.Text + "%";
            query = $"SELECT animeName, startDate, endDate, rating FROM ANIME WHERE animeName LIKE @searchParam";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@searchParam", searchQuery);
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds, "ANIME");
            kdgvAnime.DataSource = ds.Tables["ANIME"].DefaultView;
            kdgvAnime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kdgvAnime.AutoResizeColumns();
        }

    }
}
