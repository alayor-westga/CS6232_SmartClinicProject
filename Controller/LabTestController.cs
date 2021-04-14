using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// Middleware between the LabTestDAL and the View.
    /// </summary>
    public class LabTestController
    {
        private readonly LabTestDAL labTestSource;

        /// <summary>
        /// It creates a LabTestController object.
        /// </summary>
        public LabTestController()
        {
            labTestSource = new LabTestDAL();
        }

        /// <summary>
        /// It returns all the lab tests in the system.
        /// </summary>
        /// <returns>The list of lab tests.</returns>
        public List<LabTest> GetAllLabTests()
        {
            return labTestSource.GetAllLabTests();
        }

        public void AddOrderedTests(List<LabTestResults> orderedTests)
        {
            try
            {
                this.labTestSource.AddOrderedTests(orderedTests);
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        public List<LabTestResults> GetTestsForAppointment(int appointmentID)
        {
            return this.labTestSource.GetTestsForAppointment(appointmentID);
        }

        public LabTestResults GetSingleLabTestResult(string labTestCode, int appointmentID)
        {
            return this.labTestSource.GetSingleLabTestResult(labTestCode, appointmentID);
        }

        public bool UpdateLabTestResults(LabTestResults oldResults, LabTestResults newResults, string updateVariation)
        {
            return this.labTestSource.UpdateLabTestResults(oldResults, newResults, updateVariation);
        }
    }
}