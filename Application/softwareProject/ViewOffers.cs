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
    public partial class ViewOffers : Form
    {
        string ordb = "Data source=orcl ; User Id=scott ; Password=tiger;";
        OracleConnection connection;
        public ViewOffers()
        {
            InitializeComponent();
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection = new OracleConnection(ordb);
                connection.Open();

                OracleCommand cmd = new OracleCommand("GET_PRODUCTS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("name", comboBox1.SelectedItem.ToString());
                cmd.Parameters.Add("product_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txt_PRODTYPE.Text = dr[0].ToString();
                    txt_DESCRIPTION.Text = dr[1].ToString();
                    txt_IMAGE_URL.Text = dr[2].ToString();
                    txt_START_PRICE.Text = dr[3].ToString();
                    txt_START_DATE.Text = dr[4].ToString();
                    txt_END_DATE.Text = dr[5].ToString();
                }
                dr.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message, "Oracle Exception");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void ViewOffers_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ordb);
            connection.Open();

            OracleCommand cmd = new OracleCommand("GET_PRODUCTS_NAME", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("product_cur", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            dr.Close();
        }
    }
}
