using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Emploee : Staff
    {
        public Emploee(string name, List<TimeRecord> timeRecords) : base(name, 120000, timeRecords)
        {
            
        }
    }
}
