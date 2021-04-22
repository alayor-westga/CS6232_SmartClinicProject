using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartClinic.UserControls
{
    public partial class MostPerformedTestUserControl : UserControl
    {
        public MostPerformedTestUserControl()
        {
            InitializeComponent();
        }

        private void MostPerformedTestsForm_Load(object sender, EventArgs e)
        {

            this.getMostPerformedTestsDuringDatesTableAdapter.Fill(this._cs6232_g1DataSet.getMostPerformedTestsDuringDates, DateTime.Parse("1/1/2019"), DateTime.Parse("1/1/2022"));

            this.reportViewer1.RefreshReport();
        }
    }
}
