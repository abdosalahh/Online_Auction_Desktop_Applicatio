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
    public partial class Login : Form
    {
        string ordb = "Data source=orcl ; User Id=scott ; Password=tiger;";
        OracleConnection conn = null;

        public static int logId;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            String Pnumber = logpntxt.Text;
            String Pass = logpasstxt.Text;

            if (Pnumber.Length == 0 || Pass.Length == 0)
            {
                MessageBox.Show("Please enter phone number and password");
            }

            cmd.CommandText = "select UserId,phone_number,UserPassword from Users " +
                "where phone_number =:logpntxt and UserPassword =:logpasstxt";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("logpntxt", Pnumber);
            cmd.Parameters.Add("logpasstxt", Pass);

            OracleDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                logId = Int32.Parse(r[0].ToString());
                this.Hide();
                Home h = new Home();
                h.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phone number or Password is not correct");
            }
            r.Close();
        }
    }
}
