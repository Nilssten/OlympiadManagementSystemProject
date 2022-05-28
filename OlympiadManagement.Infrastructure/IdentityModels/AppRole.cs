using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure.IdentityModels
{
    public class AppRole : IdentityRole<Guid>
    {
        public AppRole()
        {
        }

        public AppRole(string roleName) : base(roleName)
        {
        }

        public static AppRole createAppRole(string rolename)
        {
            return new AppRole(rolename);
        }
    }
}
