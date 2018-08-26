using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Domain.Enumerators;
using VolvoTest.Domain.Exceptions;
using VolvoTest.Domain.Interfaces;

namespace VolvoTest.Domain.Entities
{
    public class Car : Vehicle
    {
        public Car(int chassisNumber, string chassisSeries, string color)
        {
            ChassisID = new ChassisID(chassisNumber, chassisSeries);

            if (string.IsNullOrWhiteSpace(color))
            {
                throw new DomainException(color);
            }

            Color = color;
        }

        protected override TypeVehicle Type => TypeVehicle.Car;
        protected override int NumberPassengers => 4;
    }
}
