using OlympiadManagement.Core.Aggregates.EducationAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.UserProfileAggregate
{
    public class Evaluator 
    {
        public Guid EvaluatorID { get;private set; }

        public string Education { get;private set; }


        private readonly List<Olympiad> _olympiads = new();
        public IEnumerable<Olympiad> Olympiads { get { return _olympiads; } }

        public UserProfile Profile { get;private set; }

        public Guid ProfileID { get;private set; }

        private Evaluator()
        {

        }

        public void AddOlympiad(Olympiad olympiad)
        {
            _olympiads.Add(olympiad);
        }
        public void RemoveOlympiad(Olympiad olympiad)
        {
            var item = _olympiads.Find(ol => ol.OlympiadID == olympiad.OlympiadID);
            _olympiads.Remove(item);
        }

        public static Evaluator CreateEvaluator(UserProfile profile , string education , Guid profileID)
        {

            var evaluator = new Evaluator { Profile = profile, Education = education , ProfileID = profileID };
            return evaluator;

        }
    }
}
