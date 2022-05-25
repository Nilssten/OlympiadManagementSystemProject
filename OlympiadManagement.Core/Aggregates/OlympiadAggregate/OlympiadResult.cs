using OlympiadManagement.Core.Aggregates.UserProfileAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core
{
    public class OlympiadResult
    {

        private OlympiadResult()
        {

        }

        private readonly List<Participant> _participants = new();

        public Guid OlympiadResultID { get; private set; }

        public Guid OlympiadID { get; private set; }

        public Olympiad Olympiad { get;private set; }

        public Guid ParticipantID { get;private set; }

        public Guid EvaluatorID { get;private set; }

        public IEnumerable<Participant> Participant { get { return _participants; } }

        public int Place { get;private set; }

        public int Points { get;private set; }

        public DateTime CreatedDate { get;private set; }

        public DateTime LastModified { get;private set; }

        //Guid olympiadId


        public void AddParticipant(Participant participant)
        {
            _participants.Add(participant);
        }

        public static OlympiadResult CreateOlympiadResult( Guid participantID  , Guid olympiadId , 
             Guid evaluatorID , int place , int points)
        {


            //validatiion goes here...
            //error handling goes here...
            //error notification strategies goes here...

            var olympiadResult = new OlympiadResult
            {
                OlympiadID = olympiadId,
                ParticipantID = participantID , 
                EvaluatorID = evaluatorID , 
                Place = place ,
                Points = points ,
                CreatedDate = DateTime.UtcNow , 
                LastModified = DateTime.UtcNow
            };

            return olympiadResult;
        }


    }
}
