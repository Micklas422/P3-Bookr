using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Bookr.Commons.CustomExceptions
{
    class BadPasswordException : Exception
    {
        public BadPasswordException(string message) : base(message)
        {

        }
    }
}
