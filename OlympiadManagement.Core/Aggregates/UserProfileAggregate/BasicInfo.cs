using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.UserProfileAggregate
{
    public class BasicInfo
    {

        public string FirstName { get;private set; }
        public string LastName { get;private set; }
        public string Email { get;private set; }
        public string Adress { get;private set; }
        public DateTime DateOfBirth { get;private set; }
        public int Gender { get;private set; }
        public int PersonalCode { get;private set; }
        public string PhoneNumber { get;private set; }

        public string City { get;private set; }

        private BasicInfo() { }

        public static BasicInfo CreateBasicInfo(string email , int personalCode)
        {
            return new BasicInfo { Email = email, PersonalCode = personalCode };
        }

        public static BasicInfo CreateBasicInfo(string firstName , string lastName , string email ,
            string adress , DateTime dateOfBirth , int personalCode , string phoneNumber)
        {

            var basicInfo = new BasicInfo
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Adress = adress,
                DateOfBirth = dateOfBirth,
                PersonalCode = personalCode,
                PhoneNumber = phoneNumber
            };

            return basicInfo;


        }

    }
}
