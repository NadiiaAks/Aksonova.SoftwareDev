using System;
using System.Collections.Generic;
using Domain;
using Domain.Persons;

namespace Persistence
{
    public interface IRepository
    {
        List<User> Users(); // List of users

        /// <summary>
        /// Method for creating users
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userRole"></param>
        bool UserCreate (UserRole userRole, string name);

        /// <summary>
        /// Method for reading users
        /// </summary>
        User UserGet(string name);

        /// <summary>
        /// Method for add work hours
        /// </summary>
        /// <param name="userRole"></param>
        /// <param name="timeRecord"></param>
        void TimeRecordAdd (UserRole userRole, TimeRecord timeRecord);
        /// <summary>
        /// Methods to view work hours for a specific period
        /// </summary>
        /// <param name="userRole"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        List<TimeRecord> ReportGet(UserRole userRole, DateTime? from = null, DateTime? to = null);
        List<TimeRecord> ReportGetByUser (string name, UserRole userRole, DateTime? from = null, DateTime? to = null);

        List<TimeRecord> Emploees();
        List<TimeRecord> Managers();
        List<TimeRecord> Freelancers();

    }
}
