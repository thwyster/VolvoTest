using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Domain.Exceptions;

namespace VolvoTest.Domain.Entities
{
    public class ChassisID
    {
        private int _chassisNumber { get; set; }
        private string _chassisSeries { get; set; }

        public ChassisID(int chassisNumber, string chassisSeries)
        {
            if (chassisNumber <= 0 || string.IsNullOrWhiteSpace(chassisSeries))
            {
                throw new DomainException(chassisNumber, chassisSeries);
            }

            _chassisNumber = chassisNumber;
            _chassisSeries = chassisSeries;
        }

        public string Chassis => $"{_chassisSeries}-{_chassisNumber}";
    }
}
