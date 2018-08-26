using System;
using System.Collections.Generic;
using System.Text;

namespace VolvoTest.Domain.Interfaces
{
    public interface IRepository
    {
        void Insert(IVehicle vehicle);
        void Update(IVehicle vehicle, string color);
        bool Delete(IVehicle vehicle);
        IVehicle Find(string chassis);
        List<IVehicle> ListAll(); 
    }
}
