using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Domain.Entities;
using VolvoTest.Domain.Enumerators;
using VolvoTest.Domain.Interfaces;

namespace VolvoTest.Domain.Entities
{
    public abstract class Vehicle : IVehicle
    {
        public string Chassis => ChassisID.Chassis;

        protected ChassisID ChassisID { get; set; }
        protected virtual TypeVehicle Type { get; }
        protected virtual int NumberPassengers { get; }
        protected string Color { get; set; }

        public string ColorVehicle => this.Color;

        public override string ToString()
        {
            return base.ToString();
        }

        public void UpdateColor(string color)
        {
            this.Color = color;
        }
    }
}
