using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car car;

        [TestInitialize]
        public void SetUp()
        {
            car = new Car(2, "firee", 45678, "wkwo2");
        }
        [TestMethod()]
        public void ConstructorTest()
        {
            Car car1 = new Car(2, "firee", 45678, "wkwo2");

            Assert.AreEqual(2,car1.Id);
            Assert.AreEqual("firee",car1.Model);
            Assert.AreEqual(45678, car1.Price);
            Assert.AreEqual("wkwo2", car1.LicensePlate);

        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.AreEqual(45678, car.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => car.Price = 0));
        }

        [TestMethod()]
        public void ModelTest()
        {
            Assert.AreEqual("firee", car.Model);
            Assert.ThrowsException<ArgumentNullException>((() => car.Model = null));
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => car.Model = "hi"));
        }

        [TestMethod()]
        public void LicensePlateTest()
        {
            Assert.AreEqual("wkwo2",car.LicensePlate);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "h");
        }



    }
}