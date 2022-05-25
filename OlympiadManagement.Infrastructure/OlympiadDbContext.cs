using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OlympiadManagement.Core;
using OlympiadManagement.Core.Aggregates.UserProfileAggregates;
using OlympiadManagement.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadManagement.Infrastructure
{
    public class OlympiadDbContext : IdentityDbContext
    {

        public OlympiadDbContext(DbContextOptions<OlympiadDbContext> options) : base(options)
        {

        }


        public DbSet<Olympiad> Olympiads { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<OlympiadResult> OlympiadResults { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Applicant> Applicants { get; set; }

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

           
            




        }


    }
}
