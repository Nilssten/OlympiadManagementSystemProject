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
    public class ParticipantDbRepository : IParticipantRepository
    {


        private readonly IDbContextFactory<ApplicationDbContext> _factory;
        public ParticipantDbRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;   
        }

        public async Task<Participant> CreateParticipantAsync(Participant participant)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                ctx.Participants.Add(participant);
                await ctx.SaveChangesAsync();
                return participant;
            }
            catch (Exception)
            {

                throw;
            }

            

        }

        public async Task DeleteParticipantAsync(string ID)
        {

            try
            {
                using var ctx = _factory.CreateDbContext();
                var participant = await ctx.Participants.FirstOrDefaultAsync(p => p.ParticipantID == Guid.Parse(ID));

                if (participant is null) return ;

                ctx.Participants.Remove(participant);
                await ctx.SaveChangesAsync();


            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<Participant> GetParticipantAsync(string ID)
        {
            try
            {
                using var ctx = _factory.CreateDbContext();
                var participant = await ctx.Participants.FirstOrDefaultAsync(p => p.ParticipantID == Guid.Parse(ID));
                //if (participant is null) return;
                return participant;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Participant>> GetParticipantsAsync()
        {
            using var ctx = _factory.CreateDbContext();
            return await ctx.Participants.ToListAsync();
        }

        //inteded to change particpant for olympiad i guess
        //or probably it will be useless operation for buisseness scopre requirements
        public async Task UpdateParticipantAsync(Participant participant)
        {
            using var ctx = _factory.CreateDbContext();

            //var dbParticipant = await ctx.Participants.FirstOrDefaultAsync(p => p.ParticipantID == participant.ParticipantID);
            ctx.Participants.Update(participant);
            await ctx.SaveChangesAsync();



        }
    }
}
