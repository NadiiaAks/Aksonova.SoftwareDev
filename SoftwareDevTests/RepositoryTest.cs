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
    }
}