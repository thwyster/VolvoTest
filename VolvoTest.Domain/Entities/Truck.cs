﻿using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Domain.Enumerators;
using VolvoTest.Domain.Exceptions;

namespace VolvoTest.Domain.Entities
{
    public class Truck : Vehicle
    {
        public Truck(int chassisNumber, string chassisSeries, string color)
        {
            ChassisID = new ChassisID(chassisNumber, chassisSeries);

            if (string.IsNullOrWhiteSpace(color))
            {
                throw new DomainException(color);
            }

            Color = color;
        }

        protected override TypeVehicle Type => TypeVehicle.Truck;
        protected override int NumberPassengers => 1;
    }
}
