using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.UserProfileAggregates
{
    public class Admin 
    {

        public Guid AdminID { get;private set; }

        public UserProfile Profile { get;private set; }

        private Admin()
        {

        }

        public static Admin CreateSuperAdmin(UserProfile profile)
        {
            var superAdmin = new Admin { Profile = profile };
            return superAdmin;
        }

    }
}
