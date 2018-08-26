using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Domain.Enumerators;

namespace VolvoTest.Domain.Interfaces
{
    public interface IServicesDO
    {
        void Insert(string chassisSeries, int chassisNumber, TypeVehicle typeVehicle, string color);
        void Update(string chassis, string color);
        bool Delete(string chassis);
        IVehicle Find(string chassis);
        List<IVehicle> ListAll();
    }
}
