
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.UserProfileAggregate
{
    public class UserProfile 
    {

        public Guid UserProfileID { get;private set; }

        //public string Identity { get;private set; }

        public BasicInfo BasicInfo { get;private set; }

        public DateTime DateCreated { get;private set; }

        public DateTime LastModified { get;private set; }






        protected UserProfile() {}

        public static UserProfile CreateUserProfile(BasicInfo basicInfo)
        {
            var userProfile = new UserProfile {

                //Identity = identity,
                BasicInfo = basicInfo,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow

            };
            return userProfile;
        }

        public void UpdateBasicInfo(BasicInfo newInfo)
        {
            BasicInfo = newInfo;
            LastModified = DateTime.UtcNow;
        }

    }
}
