using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Domain.Interfaces;
using VolvoTest.IOC;

namespace VolvoTest.Test
{
    [TestClass]
    public class TestVehicle
    {
        private IServicesDO _services;

        public TestVehicle()
        {
            var services = new ServiceCollection();
            IocContainer.Configure(services);
            var provider = services.BuildServiceProvider();

            _services = provider.GetService<IServicesDO>();
        }

        [TestMethod]
        public void TestInsertVehicle()
        {
            _services.Insert("AXX", 4777, Domain.Enumerators.TypeVehicle.Car, "Silver");
            Assert.IsNotNull(_services.Find("AXX-4777"));
        }

        [TestMethod]
        public void TestDeleteVehicle()
        {
            _services.Insert("AXX", 4777, Domain.Enumerators.TypeVehicle.Car, "Silver");
            _services.Delete("AXX-4777");
            Assert.IsNull(_services.Find("AXX-4777"));
        }

        [TestMethod]
        public void TestUpdateVehicle()
        {
            string newColor = "Blue";
            _services.Insert("AXX", 4777, Domain.Enumerators.TypeVehicle.Car, "Silver");
            _services.Update("AXX-4777", newColor);
            Assert.AreEqual(newColor, _services.Find("AXX-4777").ColorVehicle);
        }
    }
}
