using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Application.Enums
{
     public sealed class Roles
    {

        public const string ADMIN = "admin";
        public const string SUPER_ADMIN = "superadmin";
        public const string EVALUATOR = "evaluator";
        public const string PARTICIPANT = "participant";
        public const string ORGANIZER = "organizer";
        public const string APPLICANT = "applicant";

        public static List<string> RoleList = new List<string>() {ADMIN , SUPER_ADMIN , EVALUATOR , PARTICIPANT , ORGANIZER , APPLICANT};
    }
}
