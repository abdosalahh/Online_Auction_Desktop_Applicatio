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
    public partial class Post_Product : Form
    {
        string ordb = "Data source=orcl ; User Id=scott ; Password=tiger;";
        OracleConnection conn = null;
        public Post_Product()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            String Name = textname.Text;
            String Type = texttype.Text;
            String StartPrice = textprice.Text;
            String Startdate = textstartdate.Text;
            String Enddate = textenddate.Text;
            String IMG_url = textimg.Text;
            String Description = textDescription.Text;

            if (Name.Length == 0 || Description.Length == 0 || StartPrice.Length == 0)
            {
                MessageBox.Show("please enter required fields");
                return;
            }
            cmd.CommandText = "insert into PRODUCTS(PId,ProdName,ProdType,start_price,start_date,end_date,image_url,description,SellerId)" +
                "values(Pid_seq.nextval,:Name,:type,:Startprice,to_date(:Startdate,'DD-MM-YYYY'), to_date(:Enddate,'DD-MM-YYYY'),:IMG_url,:Description,:Sid)";
            cmd.Parameters.Add("Name", Name);
            cmd.Parameters.Add("Type", Type);
            cmd.Parameters.Add("Startprice", StartPrice);
            cmd.Parameters.Add("Startdate", Startdate);
            cmd.Parameters.Add("Enddate", Enddate);
            cmd.Parameters.Add("IMG_url", IMG_url);
            cmd.Parameters.Add("Description", Description);
            cmd.Parameters.Add("Sid", Login.logId);

            int a = cmd.ExecuteNonQuery();
            if (a != -1)
            {
                MessageBox.Show("product insert successfully");
                textname.Text = "";
                texttype.Text = "";
                textprice.Text = "";
                textstartdate.Text = "";
                textenddate.Text = "";
                textimg.Text = "";
                textDescription.Text = "";
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }
    }
}
