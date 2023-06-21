using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace softwareProject
{
    public partial class Register : Form
    {
        string ordb = "Data source=orcl ; User Id=scott ; Password=tiger;";
        OracleConnection conn = null;
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }
        private void regbtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            String Name = regnametxt.Text;
            String Email = regemailtxt.Text;
            String Pnumber = regpntxt.Text;
            String Address = regaddtxt.Text;
            String Password = regpasstxt.Text;
            String ConfirmPassword = regpasstxt.Text;

            if (Name.Length == 0 || Pnumber.Length == 0 || Password.Length == 0)
            {
                MessageBox.Show("Please enter all fields");
                return;
            }

            bool checkResult = int.TryParse(Pnumber, out int age);
            if (!checkResult)
            {
                MessageBox.Show("Phone number is wrong");
                return;
            }

            Regex validateGuidRegex =
            new Regex("^(?=.?[A-Z])(?=.?[a-z])(?=.?[0-9])(?=.?[#?!@$%^&*-]).{8,}$");
            if (validateGuidRegex.IsMatch(Password))
            {
                MessageBox.Show("Password Should be " +
                    "Has minimum 8 characters" +
                    "At least one uppercase letter" +
                    "At least one digit" +
                    "At least one Symbolysm");
                    return;
            }

            if (!(Password.Equals(ConfirmPassword)))
            {
                MessageBox.Show("Password and Confirm Password do not match");
                return;
            }

            cmd.CommandText = "insert into Users (UserId,UserRole,FullName,email,phone_number,address,UserPassword)" +
                "values(id_seq.nextval,'user',:Name,:Email,:Pnumber,:Address,:Password)";

            cmd.Parameters.Add("Name", Name);
            cmd.Parameters.Add("Email", Email);
            cmd.Parameters.Add("Pnumber", Pnumber);
            cmd.Parameters.Add("Address", Address);
            cmd.Parameters.Add("Password", Password);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error 404");
            }
        }
    }
}
