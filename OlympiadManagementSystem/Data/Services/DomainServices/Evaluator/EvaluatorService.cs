using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;

namespace OlympiadManagementSystem.Data.Services.DomainServices
{
    public class EvaluatorService : IEvaluatorService
{

    private readonly IEvaluatorRepository _repository;
    public EvaluatorService(IEvaluatorRepository repository)
    {
        _repository = repository;
    }
    public async Task<Evaluator> CreateEvaluatorAsync(Evaluator evaluator)
    {
        try
        {

            return await _repository.CreateEvaluatorAsync(evaluator);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task DeleteEvaluatorAsync(string ID)
    {
        try
        {
            await _repository.DeleteEvaluatorAsync(ID);

        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<Evaluator> GetEvaluatorAsync(string ID)
    {
        try
        {
            return await _repository.GetEvaluatorAsync(ID);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<List<Evaluator>> GetEvaluatorsAsync()
    {
        try
        {
            return await _repository.GetEvaluatorsAsync();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task UpdateEvaluatorAsync(Evaluator evaluator)
    {
        try
        {
            await _repository.UpdateEvaluatorAsync(evaluator);
        }
        catch (Exception)
        {

            throw;
        }
    }
}
}
