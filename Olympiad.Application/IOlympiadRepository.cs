using System;
using Olympiad.Core;

namespace Olympiad.Application
{
    public interface IOlympiadRepository
    {

        Olympiad[] GetOlympiads();

        Olympiad GetOlympiadByID(string Id);

        Olympiad GetOlympiadBy(string query , string parameter)

        Olympiad CreateOlympiad(Olympiad olympiad)

        void RemoveOlympiadByID(string Id);

        Olympiad UpdateOlympiad(string Id , Olympiad updatedOlympiad)

    }
}
