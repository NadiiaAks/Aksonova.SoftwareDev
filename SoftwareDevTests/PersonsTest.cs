using NUnit.Framework;
using Domain;
using System;
using System.Collections.Generic;

namespace PersonsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ManagerTotalPay ()
        {
            Manager manager = new Manager("test", new List<TimeRecord>()
            {
                new TimeRecord (DateTime.Now.AddDays(-3), "test", 8, "test message"),
                new TimeRecord (DateTime.Now.AddDays(-2), "test", 9, "test message"),
                new TimeRecord (DateTime.Now.AddDays(-1), "test", 7, "test message"),
            });

            // total pay = 10000 + 11000 + 8750 = 29750
           
            Assert.IsTrue(manager.TotalPay == 29750);
        }
    }
}