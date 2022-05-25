using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Core
{
    public class OlympiadResult
    {

        public Olympiad Olympiad { get; set; }

        public int Place { get; set; }

        public int Points { get; set; }

        public DateTime DateTime { get; set; }

        public Participant Participant { get; set; }


    }
}
