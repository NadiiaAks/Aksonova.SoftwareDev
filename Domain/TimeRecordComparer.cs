﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TimeRecordComparer : IEqualityComparer<TimeRecord>
    {
        public bool Equals(TimeRecord x, TimeRecord y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else if (x.Date == y.Date && x.Hours == y.Hours && x.Message == y.Message && x.Name == y.Name)
                return true;
            else
                return false;
        }

        public int GetHashCode([DisallowNull] TimeRecord obj)
        {
            int hCode = obj.Date.Day ^ obj.Hours ^ obj.Message.Length ^ obj.Name.Length;
            return hCode.GetHashCode();
        }
    }
}
