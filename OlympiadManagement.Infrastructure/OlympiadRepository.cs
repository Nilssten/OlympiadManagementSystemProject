using OlympiadManagement.Application;
using OlympiadManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure
{
    public class OlympiadRepository : IOlympiadRepository
    {


        private readonly OlympiadDbContext _olympiadDbContext;

        public OlympiadRepository(OlympiadDbContext olympiadDbContext)
        {
            _olympiadDbContext = olympiadDbContext;
        }

         

        public Olympiad CreateOlympiad(Olympiad olympiad)
        {
            _olympiadDbContext.Olympiads.Add(olympiad);
            _olympiadDbContext.SaveChanges();
            return olympiad;
        }

        public List<Olympiad> GetOlympiads()
        {
           return _olympiadDbContext.Olympiads.ToList();
        }

    
    }
}
