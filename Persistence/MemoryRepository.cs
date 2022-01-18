using Domain;
using Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    class MemoryRepository : IRepository
    {
        public List<TimeRecord> Emploees()
        {
            return new List<TimeRecord>()
            {
                new TimeRecord (DateTime.Now.AddDays(-3), "Ivanov",8,"test message 1"),
                new TimeRecord (DateTime.Now.AddDays(-3), "Petrov",8,"test message 2"),
                new TimeRecord (DateTime.Now.AddDays(-2), "Ivanov",10,"test message 3"),
                new TimeRecord (DateTime.Now.AddDays(-2), "Petrov",8,"test message 4")
            };
        }

        public List<TimeRecord> Freelancers()
        {
            return new List<TimeRecord>()
            {
                new TimeRecord (DateTime.Now.AddDays(-3), "Smit",8,"test message 1"),
                new TimeRecord (DateTime.Now.AddDays(-3), "Adams",8,"test message 2"),
                new TimeRecord (DateTime.Now.AddDays(-2), "Smit",10,"test message 3"),
                new TimeRecord (DateTime.Now.AddDays(-2), "Adams",8,"test message 4")
            };
        }

        public List<TimeRecord> Managers()
        {
            return new List<TimeRecord>()
            {
                new TimeRecord (DateTime.Now.AddDays(-3), "Petrov",8,"test message 1"),
                new TimeRecord (DateTime.Now.AddDays(-2), "Petrov",10,"test message 2")
            };
        }

        public List<TimeRecord> ReportGet(UserRole userRole, DateTime? from = null, DateTime? to = null)
        {
            throw new NotImplementedException();
        }

        public List<TimeRecord> ReportGetByUser(string name, UserRole userRole, DateTime? from = null, DateTime? to = null)
        {
            throw new NotImplementedException();
        }

        public void TimeRecordAdd(UserRole userRole, TimeRecord timeRecord)
        {
            throw new NotImplementedException();
        }

        public User UserCreate(UserRole userRole, string name)
        {
            throw new NotImplementedException();
        }

        public User UserGet(string name)
        {
            throw new NotImplementedException();
        }

        public List<User> Users()
        {
            return new List<User>()
            {
                new User ("Ivanov", UserRole.Emploee),
                new User ("Petrov", UserRole.Emploee),
                new User ("Smit", UserRole.Freelancer),
                new User ("Adams", UserRole.Freelancer),
                new User ("Petrov", UserRole.Manager)
            };
        }
    }
}
