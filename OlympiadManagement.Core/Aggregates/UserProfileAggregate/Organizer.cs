using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.UserProfileAggregate
{
    public class Organizer
    {

        private readonly List<Olympiad> _olympiads = new();

        public Guid OrganizerID { get;private set; }

        public IEnumerable<Olympiad> Olympiads { get;private set; }

        public UserProfile Profile { get;private set; }
        public Guid ProfileID { get;private set; }


        private Organizer()
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

        public static Organizer CreateOrganizer(UserProfile profile)
        {

            var organizer = new Organizer { Profile = profile};
            return organizer;

        }

    }
}
