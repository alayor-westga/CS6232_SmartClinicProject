using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartClinic.Controller;

namespace SmartClinic.View
{
    public partial class LabTestsForm : Form
    {
        private readonly LabTestController labTestController;
        public LabTestsForm()
        {
            InitializeComponent();
            labTestController = new LabTestController();
        }

        private void LabTestsForm_Load(object sender, EventArgs e)
        {
            labTestsComboBox.DataSource = labTestController.GetAllLabTests();
        }
    }
}
