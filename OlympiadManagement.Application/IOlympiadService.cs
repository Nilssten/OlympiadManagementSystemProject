using OlympiadManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application
{
    public interface IOlympiadService
    {

        List<Olympiad> GetOlympiads();

        Olympiad CreateOlympiad(Olympiad olympiad);

    }
}
