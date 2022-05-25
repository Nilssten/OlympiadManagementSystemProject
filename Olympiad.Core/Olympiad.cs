using System;

namespace Olympiad.Core
{
    public class Olympiad
    {

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public Subject[] Subject { get; set; }

        public string City { get; set; }


        public string Adress { get; set; }

        public OlympiadRules Rules { get; set; }
    }
}
