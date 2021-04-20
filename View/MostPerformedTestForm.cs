using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartClinic.View
{
    public partial class MostPerformedTestForm : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        public MostPerformedTestForm(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.startDate = startDate;
            this.endDate = endDate;           
        }
    }
}
