using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.BusinessLogic.Configs;
using ResumeApp.BusinessLogic.Enums;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.BusinessLogic.Validations;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Mongo.Extensions;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.DataAccess.Sql.Extensions;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddResumeServices(this IServiceCollection services, IConfiguration configuration)
        {
            var dbOptions = configuration.GetSection(DbConnectionOptions.SectionName).Get<DbConnectionOptions>();
            switch (dbOptions.UseDbType)
            {
                case SupportedDbType.Mongo:
                    services.AddScoped<ICrudService<Certification>, CertificationService<CertificationMongoEntity>>();
                    services.AddScoped<ICrudService<Education>, EducationService<EducationMongoEntity>>();
                    services.AddScoped<ICrudService<Experience>, ExperienceService<ExperienceMongoEntity>>();
                    services.AddScoped<ICrudService<Skill>, SkillsService<SkillMongoEntity>>();
                    services.AddMongoResumeDb();
                    break;

                case SupportedDbType.Sql:
                    services.AddScoped<ICrudService<Certification>, CertificationService<CertificationSqlEntity>>();
                    services.AddScoped<ICrudService<Education>, EducationService<EducationSqlEntity>>();
                    services.AddScoped<ICrudService<Experience>, ExperienceService<ExperienceSqlEntity>>();
                    services.AddScoped<ICrudService<Skill>, SkillsService<SkillSqlEntity>>();
                    services.AddSqlResumeDb(configuration, dbOptions.SqlMaxRetries);
                    break;
            }

            services.AddScoped<IValidator<Certification>, CertificationValidator>();

            return services;
        }
    }
}