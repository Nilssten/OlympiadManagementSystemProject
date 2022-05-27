using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using OlympiadManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Application.Repositories
{
    public class EvaluatorDbRepository : IEvaluatorRepository
    {

        private readonly IDbContextFactory<ApplicationDbContext> _factory;
        public EvaluatorDbRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }
        public async Task<Evaluator> CreateEvaluatorAsync(Evaluator evaluator)
        {
            try
            {

                using var ctx = _factory.CreateDbContext();
                ctx.Evaluators.Add(evaluator);
                await ctx.SaveChangesAsync();
                return evaluator;
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

                using var ctx = _factory.CreateDbContext();
                var evaluator = await ctx.Evaluators.FirstOrDefaultAsync(ev => ev.EvaluatorID == Guid.Parse(ID));
                ctx.Evaluators.Remove(evaluator);
                await ctx.SaveChangesAsync();
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
                using var ctx = _factory.CreateDbContext();
                var evaluator = await ctx.Evaluators.FirstOrDefaultAsync(ev => ev.EvaluatorID == Guid.Parse(ID));
                return evaluator;
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
                using var ctx = _factory.CreateDbContext();
                return await ctx.Evaluators.ToListAsync();
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
                using var ctx = _factory.CreateDbContext();
                ctx.Evaluators.Update(evaluator);
                await ctx.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
