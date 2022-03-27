using System.Runtime.Serialization;
using System;
using System.Data;
using System.Data.SqlClient;

namespace studentmanagementsystem
{
    internal class LimitExcedeedException : ApplicationException
    {
        public LimitExcedeedException()
        {
        }

        public LimitExcedeedException(string? message) : base(message)
        {
        }
    }
}
