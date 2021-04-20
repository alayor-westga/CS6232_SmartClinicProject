using SmartClinic.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartClinic.UserControls
{
    public partial class MostPerformedTestsUserControl : UserControl
    {
        public MostPerformedTestsUserControl()
        {
            InitializeComponent();
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            if (startDateDateTimePicker.Value < endDateDateTimePicker.Value)
            {
                using (MostPerformedTestForm mostPerformedTestForm = new MostPerformedTestForm(this.startDateDateTimePicker.Value, this.endDateDateTimePicker.Value))
                {
                    mostPerformedTestForm.ShowDialog();
                }               
            }
            else { 
            }
        }
    }
}
