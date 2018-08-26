using System;
using System.Collections.Generic;
using System.Text;

namespace VolvoTest.Domain.Interfaces
{
    public interface IVehicle
    {
        string Chassis { get; }
        string ColorVehicle { get; }

        void UpdateColor(string color);
    }
}
