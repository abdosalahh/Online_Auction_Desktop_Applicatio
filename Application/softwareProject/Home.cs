using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace softwareProject
{
    public partial class Home : Form
    {
        string ordb = "Data source=orcl ; User Id=scott ; Password=tiger;";
        OracleConnection conn = null;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "GetOffers";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("Pcount", OracleDbType.Int32, ParameterDirection.Output);
            cmd1.ExecuteNonQuery();
            try
            {
                offers.Text = cmd1.Parameters["Pcount"].Value.ToString();
            }
            catch
            {
                offers.Text = "0";
            }
            /////////////////////////////////////////////////////////////////////
            OracleCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "GetSellers";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("Scount", OracleDbType.Int32, ParameterDirection.Output);
            cmd2.ExecuteNonQuery();
            try
            {
                sellers.Text = cmd2.Parameters["Scount"].Value.ToString();
            }
            catch
            {
                sellers.Text = "0";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Post_Product p = new Post_Product();
            p.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewOffers v = new ViewOffers();
            v.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile u = new UserProfile();
            u.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchProd s = new SearchProd();
            s.ShowDialog();
        }
    }
}
