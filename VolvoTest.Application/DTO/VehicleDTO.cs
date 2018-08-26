using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Domain.Enumerators;

namespace VolvoTest.Application.DTO
{
    public class VehicleDTO
    {
        public string ChassisSeries { get; set; }
        public int ChassisNumber { get; set; }
        public TypeVehicle TypeVehicle { get; set; }
        public string Color { get; set; }
    }
}
