using System;
using System.Collections.Generic;
using System.Text;

namespace VolvoTest.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }

        public DomainException(int chassisNumber, string chassisSeries) :
            base($"Chassis Number: {chassisNumber} or Series: {chassisSeries} invalid")
        { }
    }
}
