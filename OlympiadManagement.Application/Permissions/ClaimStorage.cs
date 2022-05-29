using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Permissions
{
    public class ClaimStorage
    {
        public static readonly Claim MANAGE_OLYMPIAD = new("Olympiad", "Manage");
        public static readonly Claim CREATE_OLYMPIAD = new("Olympiad", "Create");
        public static readonly Claim CREATE_PARTICIPANT = new("Participant", "Create");
        public static readonly Claim EVALUATE_OLYMPIAD = new("Olympiad", "Evaluate");
        public static readonly Claim MANAGE_USERS = new("Users", "Manage");
        

    }
}
