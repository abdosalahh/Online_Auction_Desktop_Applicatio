using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace report11
{
    public partial class Form2 : Form
    {
        CrystalReport2 cr;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr;
            cr.SetParameterValue(0, comboBox1.Text);

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);

        }
    }
}
