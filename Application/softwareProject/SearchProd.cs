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
    public partial class SearchProd : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public SearchProd()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void displayditl_Click_1(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id = scott; Password = tiger; ";
            string cmdstr = @"select * from PRODUCTS where ProdName= :n  ";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", ProdName.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            SelectedProd.DataSource = ds.Tables[0];
        }
    }
}
