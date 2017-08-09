using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker
{
    public class Schedule
    {
        public string person;
        public string [,] wkSchd;

        public Schedule() {
            person = "";
            wkSchd = new string[34, 7];
        }
    }
}
