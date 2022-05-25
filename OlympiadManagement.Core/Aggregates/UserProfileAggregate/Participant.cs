using OlympiadManagement.Core.Aggregates.EducationAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.UserProfileAggregates
{
    public class Participant 
    {

        private readonly List<OlympiadResult> _olympiadResults = new();

        private readonly List<Olympiad> _olympiads = new();

        public Guid ParticipantID { get; private set; }

        public UserProfile Profile { get; private set; }
        public Guid ProfileID { get;private set; }

        public IEnumerable<Olympiad> Olympiads { get { return _olympiads; } }

        public IEnumerable<OlympiadResult> OlympiadResults { get { return _olympiadResults; } }

        public School School { get; private set; }
        public Guid SchoolID { get; private set; }


        private Participant()
        {

        }

        public void UpdateOlimpiadList(Olympiad olympiad)
        {
            _olympiads.Add(olympiad);
        }
        public void UpdateResultList(OlympiadResult olympiadResult)
        {
            _olympiadResults.Add(olympiadResult);
        }

        public static Participant CreateParticipant(Guid profileID, School school , UserProfile profile , Guid schoolD)
        {
            var participant = new Participant
            {
                ProfileID = profileID,
                SchoolID = schoolD,
                Profile = profile,
                School = school
            };

            return participant;


        }
    }
}
