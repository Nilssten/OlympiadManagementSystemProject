using OlympiadManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application
{
    public interface IOlympiadRepository
    {

        Task<List<Olympiad>> GetOlympiadsAsync();

        Task<Olympiad> CreateOlympiadAsync(Olympiad olympiad);

        Task UpdateOlympiadAsync(Olympiad olympiad);

        Task<Olympiad> GetOlympiadAsync(string ID);

        Task DeleteOlympiadAsync(string ID);

    }
}
