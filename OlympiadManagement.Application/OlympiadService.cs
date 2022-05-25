using OlympiadManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application
{
    public class OlympiadService : IOlympiadService
    {

        private readonly IOlympiadRepository _olympiadRepository;

        public OlympiadService(IOlympiadRepository olympiadRepository)
        {

            _olympiadRepository = olympiadRepository;
        }

        public Olympiad CreateOlympiad(Olympiad olympiad)
        {
            _olympiadRepository.CreateOlympiad(olympiad);
            return olympiad;
        }

        public List<Olympiad> GetOlympiads()
        {
            var olympiads = _olympiadRepository.GetOlympiads();

            return olympiads;
        }
    }
}
