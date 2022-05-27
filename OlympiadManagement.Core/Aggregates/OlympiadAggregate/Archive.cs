using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Core.Aggregates.OlympiadAggregate
{
    public class Archive
    {

        public Guid ArchiveID { get;private set; }

        public Olympiad Olympiad { get;private set; }

        public IEnumerable<OlympiadResult> OlympiadResults { get;private set; }

        public DateTime DateCreated { get;private set; }

        private Archive()
        {

        }

        public static Archive CreateArchive(Olympiad olympiad , IEnumerable<OlympiadResult> results)
        {
            return new Archive
            {
                Olympiad = olympiad,
                OlympiadResults = results,
                DateCreated = DateTime.UtcNow
            };
        }



    }
}
