using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core
{
    public class OlympiadRules
    {
 
        public int MaxParticipant { get;private set; }

        public int MinParticipant { get;private set; }

        public int MaxParticipantFromApplicant { get;private set; }

        private OlympiadRules()
        {

        }

        public static OlympiadRules CreateOlympiadRules (int maxParticipant , int minParticipant , int maxParticipantFromApplicant)
        {

            var rules = new OlympiadRules
            {
                MaxParticipant = maxParticipant,
                MinParticipant = minParticipant,
                MaxParticipantFromApplicant = maxParticipantFromApplicant
            };

            return rules;

        }

    }
}
