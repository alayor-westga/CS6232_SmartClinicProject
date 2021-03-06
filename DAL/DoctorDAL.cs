using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Class that communicates with the Doctors table in the DB. 
    /// </summary>
    public class DoctorDAL
    {
        /// <summary>
        /// It returns all the doctors.
        /// </summary>
        /// <returns>All the doctors.</returns>
        public List<Doctor> GetAll()
        {
            string selectStatement =
            " SELECT d.doctor_id, cp.first_name, cp.last_name" +
            " FROM Doctors d" +
            " INNER JOIN ClinicPersons cp ON (d.clinic_person_id = cp.clinic_person_id);";
            List<Doctor> doctorList = new List<Doctor>();

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor()
                            {
                                DoctorId = Int32.Parse(reader["doctor_id"].ToString()),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                            };
                            doctorList.Add(doctor);
                        }
                    }
                }
            }
            return doctorList;
        }
    }
}