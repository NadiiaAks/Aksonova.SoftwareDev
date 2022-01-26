using NUnit.Framework;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Persistence;
using Domain.Persons; 

namespace RepositoryTest
{
    public class RepositoryTest
    {
        IRepository memoryRepository = new MemoryRepository();

        [SetUp]
        public void Setup()
        {
        }

        // Test for method UserCreate (creating new user, new user is Emploee)
        [Test]
        public void UserCreateEmploee()
        {
            bool isCreated = memoryRepository.UserCreate(UserRole.Emploee, "Test Name");
            var newUser = memoryRepository.Users().FirstOrDefault(x => x.Name == "Test Name");

            Assert.IsTrue(isCreated);
            Assert.IsNotNull(newUser);
            Assert.IsTrue(newUser.UserRole == UserRole.Emploee);
        }

        //Test for adding an existing employee
        [Test]
        public void UserCreateEmploeeExisted()
        {
            bool isCreated = memoryRepository.UserCreate(UserRole.Emploee, "Ivanov");
            var existedUser = memoryRepository.Users().FirstOrDefault(x => x.Name == "Ivanov");

            Assert.IsTrue(!isCreated);
            Assert.IsNotNull(existedUser);
            Assert.IsTrue(existedUser.UserRole == UserRole.Emploee);
        }

        // Test GetUser (user in list or not)
        [Test]
        public void UserGetTest()
        {
            var existed = memoryRepository.UserGet("Ivanov");
            var unknown = memoryRepository.UserGet("Unknown user");

            Assert.IsTrue(existed != null);

        }

        //Test for getting a user report
        [Test]
        public void ReportGetByUserTest()
        {
            var reportList = memoryRepository.ReportGetByUser("Petrov", UserRole.Emploee, null, null);
            var sampleList = new List<TimeRecord>()
            {
                new TimeRecord (DateTime.Now.Date.AddDays(-3), "Petrov",8,"test message 2"),
                new TimeRecord (DateTime.Now.Date.AddDays(-2), "Petrov",8,"test message 4")
            };

            Assert.IsTrue(Enumerable.SequenceEqual(reportList, sampleList, new TimeRecordComparer()));

        }
    }
}