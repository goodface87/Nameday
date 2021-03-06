﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nameday
{
    public class NamedayModel
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public IEnumerable<string> Names { get; set; }

        public NamedayModel(int month, int day, IEnumerable<string> names)
        {
            Month = month;
            Day = day;
            Names = names;
        }

        public string NameAsString => string.Join(", ", Names);

        public NamedayModel() {}

        //public string NameAsString
        //{
        //    get { return string.Join(", ", Names); }
        //}
    }
}
