using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentItAPI.Exceptions
{
    public class RepeatPasswordException: Exception
    {
        public RepeatPasswordException(string message) : base(message)
        {

        }
    }
}
