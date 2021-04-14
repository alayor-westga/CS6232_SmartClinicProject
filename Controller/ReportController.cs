using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// Middleware between the ReportDAL and the View.
    /// </summary>
    public class ReportController
    {
        private readonly ReportDAL reportSource;

        /// <summary>
        /// It creates a ReportController object.
        /// </summary>
        public ReportController()
        {
            this.reportSource = new ReportDAL();
        }

        /// <summary>
        ///  Gets the statistics that show the most performed tests during the 
        ///  specified period of time for the tests that were performed at least twice.
        /// </summary>
        /// <param name="startDate">The start date range within the tests were performed.</param>
        /// <param name="endDate">The end date range within the tests were performed.</param>
        /// <returns>The list of most performed test during the specified date range.</returns>
        public List<MostPerformedTestDuringDates> getMostPerformedTestsDuringDates(DateTime startDate, DateTime endDate)
        {
            if (startDate == null)
            {
                throw new ArgumentNullException("startDate");
            }
            if (endDate == null)
            {
                throw new ArgumentNullException("endDate");
            }
            return reportSource.getMostPerformedTestsDuringDates(startDate, endDate);
        }
    }
}