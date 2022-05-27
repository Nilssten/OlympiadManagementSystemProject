using OlympiadManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Services
{
    public interface IOlympiadService
    {

        Task<List<Olympiad>> GetOlympiadsAsync();

        Task<Olympiad> CreateOlympiadAsync(Olympiad olympiad);

        Task UpdateOlympiadAsync(Olympiad olympiad);

        Task<Olympiad> GetOlympiadAsync(string ID);

        Task DeleteOlympiadAsync(string ID);

    }
}
