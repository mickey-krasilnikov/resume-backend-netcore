using System.Reflection;
using System.Runtime.Serialization;
using AutoMapper;
using ResumeApp.Application.Common.Interfaces;
using NUnit.Framework;
using ResumeApp.Application.Certificates.Queries.GetCertificatesWithPagination;
using ResumeApp.Application.Contacts.Queries.GetContactsWithPagination;
using ResumeApp.Application.Educations.Queries.GetEducationsWithPagination;
using ResumeApp.Application.Experiences.Queries.GetExperiencesWithPagination;
using ResumeApp.Application.Skills.Queries.GetSkillsWithPagination;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.UnitTests.Common.Mappings;

public class MappingTests
{
    private readonly IConfigurationProvider _configuration;
    private readonly IMapper _mapper;

    public MappingTests()
    {
        _configuration = new MapperConfiguration(config => 
            config.AddMaps(Assembly.GetAssembly(typeof(IApplicationDbContext))));

        _mapper = _configuration.CreateMapper();
    }

    [Test]
    public void ShouldHaveValidConfiguration()
    {
        _configuration.AssertConfigurationIsValid();
    }

    [Test]
    [TestCase(typeof(Certificate), typeof(CertificateDto))]
    [TestCase(typeof(Contact), typeof(ContactDto))]
    [TestCase(typeof(Education), typeof(EducationDto))]
    [TestCase(typeof(Experience), typeof(ExperienceDto))]
    [TestCase(typeof(Skill), typeof(SkillDto))]
    public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        var instance = GetInstanceOf(source);

        _mapper.Map(instance, source, destination);
    }

    private object GetInstanceOf(Type type)
    {
        if (type.GetConstructor(Type.EmptyTypes) != null)
            return Activator.CreateInstance(type)!;

        // Type without parameterless constructor
        // TODO: Figure out an alternative approach to the now obsolete `FormatterServices.GetUninitializedObject` method.
#pragma warning disable SYSLIB0050 // Type or member is obsolete
        return FormatterServices.GetUninitializedObject(type);
#pragma warning restore SYSLIB0050 // Type or member is obsolete
    }
}
