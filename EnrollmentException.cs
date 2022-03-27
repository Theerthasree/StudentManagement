using System;
using System;
using System.Data;
using System.Data.SqlClient;
namespace studentmanagementsystem
{

        public class EnrollmentException : ApplicationException
        {
            public EnrollmentException()
            {
            }

            public EnrollmentException(string message)
            {
                Console.WriteLine("\n" + message + "\n");
            }
        }
    }

