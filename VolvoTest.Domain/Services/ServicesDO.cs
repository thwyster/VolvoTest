using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Domain.Entities;
using VolvoTest.Domain.Enumerators;
using VolvoTest.Domain.Exceptions;
using VolvoTest.Domain.Interfaces;

namespace VolvoTest.Domain.Services
{
    public class ServicesDO : IServicesDO
    {
        private IRepository _repository;

        public ServicesDO(IRepository repository)
        {
            _repository = repository;
        }

        public bool Delete(string chassis)
        {
            var objVehicle = _repository.Find(chassis);
            if (objVehicle == null)
            {
                throw new DomainException("Vehicle not found");
            }

            return _repository.Delete(objVehicle);
        }

        public IVehicle Find(string chassis)
        {
            var objVehicle = _repository.Find(chassis);
            if (objVehicle == null)
            {
                return null;
            }

            return objVehicle;
        }

        public void Insert(string chassisSeries, int chassisNumber, TypeVehicle typeVehicle, string color)
        {
            switch (typeVehicle)
            {
                case TypeVehicle.Bus:
                    _repository.Insert(new Bus(chassisNumber, chassisSeries, color));
                    break;
                case TypeVehicle.Truck:
                    _repository.Insert(new Truck(chassisNumber, chassisSeries, color));
                    break;
                case TypeVehicle.Car:
                    _repository.Insert(new Car(chassisNumber, chassisSeries, color));
                    break;
                default:
                    throw new DomainException("Type invalid");
            }
        }

        public List<IVehicle> ListAll()
        {
            return _repository.ListAll();
        }

        public void Update(string chassis, string color)
        {
            var objVehicle = _repository.Find(chassis);
            if (objVehicle == null)
            {
                throw new DomainException("Vehicle not found");
            }

            _repository.Update(objVehicle, color);
        }
    }
}
