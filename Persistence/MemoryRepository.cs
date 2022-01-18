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
            throw new NotImplementedException();
        }

        public List<TimeRecord> Freelancers()
        {
            throw new NotImplementedException();
        }

        public List<TimeRecord> Managers()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
