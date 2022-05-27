using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Core;
using OlympiadManagement.Core.Aggregates.EducationAggregate;
using OlympiadManagement.Core.Aggregates.OlympiadAggregate;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using OlympiadManagement.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Olympiad> Olympiads { get; set; } //check
        public DbSet<Admin> Admins { get; set; }
        public DbSet<OlympiadResult> OlympiadResults { get; set; } //check
        public DbSet<UserProfile> UserProfiles { get; set; } //check
        public DbSet<Applicant> Applicants { get; set; } //check
        public DbSet<Participant> Participants { get; set; } //check
        public DbSet<Evaluator> Evaluators { get; set; } // check
        public DbSet<School> Schools { get; set; } //school
        public DbSet<Archive> Archives { get; set; } //check
        public DbSet<Organizer> Organizers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EvaluatorConfig());
            builder.ApplyConfiguration(new OlympiadConfig());
            builder.ApplyConfiguration(new OlympiadResultConfig());
            builder.ApplyConfiguration(new ParticipantConfig());
            builder.ApplyConfiguration(new SchoolConfiguration());
            builder.ApplyConfiguration(new UserProfileConfig());
            builder.ApplyConfiguration(new IdentityUserLoginConfig());
            builder.ApplyConfiguration(new IdentityUserRoleConfig());
            builder.ApplyConfiguration(new IdentityUserTokenConfig());
            builder.ApplyConfiguration(new ArchiveConfig());

        }


    }
}
