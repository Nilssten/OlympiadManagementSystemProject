using OlympiadManagement.Core.Aggregates.UserProfileAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.EducationAggregates
{
    public class School
    {
        public Guid SchoolID { get;private set; }
        public string Adress { get;private set; }
        public string Name { get;private set; }
        public string City { get;private set; } = string.Empty;
        public string Region { get;private set; } = string.Empty;

        

        private School()
        {

        }

        public static School CreateSchool(string adress , string name , string city , string region )
        {
            var school = new School { Adress = adress, Name = name, City = city, Region = region };
            return school;
        }
    }
}
