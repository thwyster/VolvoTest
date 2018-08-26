using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VolvoTest.Domain.Interfaces;

namespace VolvoTest.Repository
{
    public class RepositoryVehicles : IRepository
    {
        private List<IVehicle> listVehicles = new List<IVehicle>();

        public bool Delete(IVehicle vehicle)
        {
            return listVehicles.Remove(vehicle);
        }

        public IVehicle Find(string chassis)
        {
            return listVehicles.FirstOrDefault(w => w.Chassis == chassis);
        }

        public void Insert(IVehicle vehicle)
        {
            listVehicles.Add(vehicle);
        }

        public List<IVehicle> ListAll()
        {
            return listVehicles;
        }

        public void Update(IVehicle vehicle, string color)
        {
            vehicle.UpdateColor(color);
        }
    }
}
