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

        #region Fake Data
        private List<TimeRecord> emploees = new List<TimeRecord>()
        {
            new TimeRecord (DateTime.Now.AddDays(-3), "Ivanov",8,"test message 1"),
            new TimeRecord (DateTime.Now.AddDays(-3), "Petrov",8,"test message 2"),
            new TimeRecord (DateTime.Now.AddDays(-2), "Ivanov",10,"test message 3"),
            new TimeRecord (DateTime.Now.AddDays(-2), "Petrov",8,"test message 4")
        };

        private List<TimeRecord> freelancers = new List<TimeRecord>()
        {
            new TimeRecord (DateTime.Now.AddDays(-3), "Smit",8,"test message 1"),
            new TimeRecord (DateTime.Now.AddDays(-3), "Adams",8,"test message 2"),
            new TimeRecord (DateTime.Now.AddDays(-2), "Smit",10,"test message 3"),
            new TimeRecord (DateTime.Now.AddDays(-2), "Adams",8,"test message 4")
        };

        private List<TimeRecord> managers = new List<TimeRecord>()
        {
             new TimeRecord (DateTime.Now.AddDays(-3), "Petrov",8,"test message 1"),
             new TimeRecord (DateTime.Now.AddDays(-2), "Petrov",10,"test message 2")
        };

        private List<User> users = new List<User>()
        {
            new User ("Ivanov", UserRole.Emploee),
            new User ("Petrov", UserRole.Emploee),
            new User ("Smit", UserRole.Freelancer),
            new User ("Adams", UserRole.Freelancer),
            new User ("Petrov", UserRole.Manager)

        }; 
        #endregion

        public List<TimeRecord> Emploees()
        {
            return emploees;
        }

        public List<TimeRecord> Freelancers()
        {
            return freelancers;
        }

        public List<TimeRecord> Managers()
        {
            return managers;
        }

        public List<TimeRecord> ReportGet(UserRole userRole, DateTime? from = null, DateTime? to = null)
        {
            var records = new List<TimeRecord>();
            switch (userRole)
            {
                case UserRole.Manager:
                    records = Managers();
                    break;
                case UserRole.Emploee:
                    records = Emploees();
                    break;
                case UserRole.Freelancer:
                    records = Freelancers();
                    break;
                default:
                    throw new NotImplementedException("Unknown role!");
            }

            if(from == null)
            {
                from = DateTime.Now.AddYears(-100);
            }
            if (to == null)
            {
                to = DateTime.Now;
            }

            return records.Where(x => from.Value >= x.Date && x.Date <= to).ToList();

        }

        public List<TimeRecord> ReportGetByUser(string name, UserRole userRole, DateTime? from = null, DateTime? to = null)
        {
            throw new NotImplementedException();
        }

        public void TimeRecordAdd(UserRole userRole, TimeRecord timeRecord)
        {
            throw new NotImplementedException();
        }

        public bool UserCreate(UserRole userRole, string name)
        {
            var newUser = new User(name, userRole);
            User existedUser = UserGet(name);
            if(existedUser == null)
            {
                users.Add(newUser);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public User UserGet(string name)
        {
            return Users().FirstOrDefault(x => x.Name == name);
        }

        public List<User> Users()
        {
            return users;
        }
    }
}
