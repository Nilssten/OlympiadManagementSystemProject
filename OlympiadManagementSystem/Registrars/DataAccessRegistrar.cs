using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlympiadManagement.Application;
using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Infrastructure;
using OlympiadManagement.Infrastructure.DataAccess;
using OlympiadManagementSystem.Data.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Registrars
{
    public class DataAccessRegistrar : IServiceCollectionRegistrar
    {
        public void RegisterServices(IServiceCollection services , IConfiguration configuration)
        {
            //Olympiad
            services.AddScoped<IOlympiadRepository, OlympiadDbRepository>();
            services.AddScoped<IOlympiadService, OlympiadService>();
            //Olympiad results
            services.AddScoped<IOlympiadResultRepository, OlympiadResultDbRepository>();
            services.AddScoped<IOlympiadResultService, OlympiadResultService>();
            //User Profile
            services.AddScoped<IUserProfileRepository, UserProfileDbRepository>();
            services.AddScoped<IUserProfileService, UserProfileService>();
            //Participants
            services.AddScoped<IParticipantRepository, ParticipantDbRepository>();
            services.AddScoped<IParticipantSevice, ParticipantService>();
            //Applicants
            services.AddScoped<IApplicantRepository, ApplicantDbRepository>();
            services.AddScoped<IApplicantService, ApplicantService>();
            //Evaluators
            services.AddScoped<IEvaluatorRepository, EvaluatorDbRepository>();
            services.AddScoped<IEvaluatorService, EvaluatorService>();
            //archive
            services.AddScoped<IArchiveRepository, ArchiveDbRepository>();
            services.AddScoped<IArchiveService, ArchiveService>();
            //school
            services.AddScoped<ISchoolRepository, SchoolDbRepository>();
            services.AddScoped<ISchoolService, SchoolService>();
            //admin
            services.AddScoped<IAdminRepository, AdminDbRepository>();
            services.AddScoped<IAdminService, AdminService>();
            //organizer
            services.AddScoped<IOrganizerRepository, OrganizerDbRepository>();
            services.AddScoped<IOrganizerService, OrganizerService>();




        }
    }
}
