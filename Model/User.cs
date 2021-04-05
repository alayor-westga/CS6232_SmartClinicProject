using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    /// <summary>
    /// The User model class.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The User ID.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The User Name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The User Full Name.
        /// </summary>
        public string FullName { get; set; }
    }
}
