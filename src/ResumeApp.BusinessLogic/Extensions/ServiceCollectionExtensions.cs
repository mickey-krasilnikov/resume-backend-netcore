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
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddResumeServices(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(services, nameof(services));
			ArgumentNullException.ThrowIfNull(configuration, nameof(configuration));

            var dbOptions = configuration.GetSection(DbConnectionOptions.SectionName).Get<DbConnectionOptions>();
            switch (dbOptions.UseDbType)
            {
                case SupportedDbType.Mongo:
                    services.AddScoped<ICrudService<CertificationDto>, CertificationService<CertificationMongoEntity>>();
					services.AddScoped<ICrudService<ContactDto>, ContactsService<ContactMongoEntity>>();
					services.AddScoped<ICrudService<EducationDto>, EducationService<EducationMongoEntity>>();
                    services.AddScoped<ICrudService<ExperienceDto>, ExperienceService<ExperienceMongoEntity>>();
                    services.AddScoped<ICrudService<SkillDto>, SkillsService<SkillMongoEntity>>();
                    services.AddMongoResumeDb();
                    break;

                case SupportedDbType.Sql:
					services.AddScoped<ICrudService<CertificationDto>, CertificationService<CertificationSqlEntity>>();
					services.AddScoped<ICrudService<ContactDto>, ContactsService<ContactSqlEntity>>();
					services.AddScoped<ICrudService<EducationDto>, EducationService<EducationSqlEntity>>();
                    services.AddScoped<ICrudService<ExperienceDto>, ExperienceService<ExperienceSqlEntity>>();
                    services.AddScoped<ICrudService<SkillDto>, SkillsService<SkillSqlEntity>>();
                    services.AddSqlResumeDb(configuration, dbOptions.SqlMaxRetries);
                    break;
            }

            services.AddScoped<IValidator<CertificationDto>, CertificationValidator>();
			services.AddScoped<IValidator<ContactDto>, ContactValidator>();
			services.AddScoped<IValidator<EducationDto>, EducationValidator>();
			services.AddScoped<IValidator<ExperienceDto>, ExperienceValidator>();
			services.AddScoped<IValidator<SkillDto>, SkillValidator>();

			return services;
        }
    }
}