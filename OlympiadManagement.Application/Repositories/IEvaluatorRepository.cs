using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public interface IEvaluatorRepository
    {
        Task<List<Evaluator>> GetEvaluatorsAsync();

        Task<Evaluator> CreateEvaluatorAsync(Evaluator evaluator);

        Task UpdateEvaluatorAsync(Evaluator evaluator);

        Task<Evaluator> GetEvaluatorAsync(string ID);

        Task DeleteEvaluatorAsync(string ID);
    }
}
