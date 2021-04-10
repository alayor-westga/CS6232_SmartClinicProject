using SmartClinic.Controller;
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
    public partial class LabTestDetailsForm : Form
    {
        private readonly LabTestController labTestController;

        public LabTestDetailsForm()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
        }

        private void ThisFormLoad_Load(object sender, EventArgs e)
        {
            this.labTestComboBox.DataSource = this.labTestController.GetAllLabTests();
        }
    }
}
