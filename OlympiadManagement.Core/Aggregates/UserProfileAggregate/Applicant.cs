using OlympiadManagement.Core.Aggregates.EducationAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.UserProfileAggregate
{
    public class Applicant
    {

        private readonly List<Participant> _participants = new();

        public Guid ApplicantID { get;private set; }

        public string Education { get; private set; }

        public IEnumerable<Participant> Participants { get { return _participants; } }

        public UserProfile Profile { get; private set; }
        public Guid ProfileID { get;private set; }

        public School School { get;private set; }


        private Applicant()
        {
            
        }

        public void RegisterParticipant(Guid profileID , School school , UserProfile profile , Guid schoolID)
        {
            var participant = Participant.CreateParticipant(profileID, school , profile ,  schoolID);
            _participants.Add(participant);
        }

        //public void RegisterParticipant() { }

        public static Applicant CreateApplicant(string education , UserProfile profile , School school , Guid profileID)
        {
            var applicant = new Applicant { Education = education  , Profile = profile , School = school , ProfileID = profileID};
            return applicant;
        }




    }
}
