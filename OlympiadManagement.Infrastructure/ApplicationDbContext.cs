using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Core;
using OlympiadManagement.Core.Aggregates.EducationAggregate;
using OlympiadManagement.Core.Aggregates.OlympiadAggregate;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using OlympiadManagement.Infrastructure.Configurations;
using OlympiadManagement.Infrastructure.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole , Guid>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<AppUser> Identities { get; set; }
        public DbSet<Olympiad> Olympiads { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<OlympiadResult> OlympiadResults { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Evaluator> Evaluators { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Archive> Archives { get; set; }
        public DbSet<Organizer> Organizers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EvaluatorConfig());
            builder.ApplyConfiguration(new OlympiadConfig());
            builder.ApplyConfiguration(new OlympiadResultConfig());
            builder.ApplyConfiguration(new ParticipantConfig());
            builder.ApplyConfiguration(new SchoolConfiguration());
            builder.ApplyConfiguration(new UserProfileConfig());
            builder.ApplyConfiguration(new ArchiveConfig());

            base.OnModelCreating(builder);

            


        }


    }
}
