using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace softwareProject
{
    public partial class UserProfile : Form
    {
        string ordb = "Data source=orcl ; User Id=scott ; Password=tiger;";
        OracleConnection conn = null;
        public UserProfile()
        {
            InitializeComponent();
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }
        private void UserProfile_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select UserId,UserRole,FullName,email,phone_number,address from Users" + 
                " where UserId = :Id ";

            cmd.Parameters.Add("Id", Login.logId);

            OracleDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                UserLabel.Text = r[2].ToString();
                RoleLabel.Text = r[1].ToString();
                EmailLabel.Text = r[3].ToString();
                PhoneLabel.Text = r[4].ToString();
                LocLabel.Text = r[5].ToString();
            }
            else
            {
                MessageBox.Show("Error 404");
            }
            r.Close();
        }
    }
}
