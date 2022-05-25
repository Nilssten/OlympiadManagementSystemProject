using OlympiadManagement.Core.Aggregates.EducationAggregates;
using OlympiadManagement.Core.Aggregates.UserProfileAggregates;
using System;
using System.Collections.Generic;

namespace OlympiadManagement.Core
{
    public class Olympiad
    {

        public Guid OlympiadID { get;private set; }

        public DateTime DateTime { get;private set; }

        public DateTime DateCreated { get;private set; }
        public DateTime? LastModified { get;private set; }

        public string Subject { get;private set; }

        public string City { get;private set; }
        
        public string Adress { get;private set; }
        
        public OlympiadRules Rules { get;private set; }
         
        public IEnumerable<Evaluator>  Evaluators { get;private set; }

        public IEnumerable<Participant> Participants { get;private set; }


        //public Guid EvaluatorID { get; set; }

        private Olympiad(){ }

        public static Olympiad CreateOlympiad(DateTime date , string subject , string city , string adress ,
            OlympiadRules rules , IEnumerable<Evaluator> evaluators , IEnumerable<Participant> participants)
        {

            var olympiad = new Olympiad { 
                DateTime = date ,
                Subject = subject , 
                City = city , 
                Adress = adress ,
                Rules = rules , 
                Evaluators = evaluators , 
                Participants = participants
            };

            return olympiad;
        }


    }
}
