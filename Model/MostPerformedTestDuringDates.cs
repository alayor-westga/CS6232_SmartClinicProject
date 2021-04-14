using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    /// <summary>
    /// Model that holds the statistics that show the most performed tests during the 
    /// specified period of time for the tests that were performed at least twice.
    /// </summary>
    public class MostPerformedTestDuringDates
    {
        /// <summary>
        /// The test code.
        /// </summary>
        public string LabTestCode { get; set; }

        /// <summary>
        /// The test name.
        /// </summary>
        public string LabTestName { get; set; }

        /// <summary>
        /// The total number of times that the qualified test has been performed in the specified date range.
        /// </summary>
        public int TestsCount { get; set; }

        /// <summary>
        /// The total number of times that all tests have been performed in the given date range.
        /// </summary>
        public int AllTestsCount { get; set; }

        /// <summary>
        /// The percentage of the number in TestsCount over the number in AllTestsCount.
        /// </summary>
        public string TestCountPercentage { get; set; }

        /// <summary>
        /// The number of normal results for the qualified test in the specified date range.
        /// </summary>
        public int NormalResultsCount { get; set; }

        /// <summary>
        /// The number of abnormal results for the qualified test in the specified date range.
        /// </summary>
        public int AbnormalResultsCount { get; set; }

        /// <summary>
        /// The percentage of the total number of times that the test was performed on 
        /// a patient in age 18-29 (at the time when the test was performed) over the 
        /// total number of times that the test has been performed in the specified date range.
        /// </summary>
        public string TestsOn18To29Percent { get; set; }

        /// <summary>
        /// The percentage of the total number of times that the test was performed on 
        /// a patient in age 30-39 (at the time when the test was performed) over the 
        /// total number of times that the test has been performed in the specified date range.
        /// </summary>
        public string TestsOn30To39Percent { get; set; }

        /// <summary>
        /// The percentage of the total number of times that the test was performed on 
        /// a patient NOT in age 18-39 (at the time when the test was performed) over the 
        /// total number of times that the test has been performed in the specified date range.
        /// </summary>
        public string TestsNotOn18To39Percent { get; set; }
    }
}
