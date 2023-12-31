using System.Reflection;
using System.Runtime.Serialization;
using AutoMapper;
using ResumeApp.Application.Common.Interfaces;
using NUnit.Framework;
using ResumeApp.Application.Certificates.Queries.GetCertificatesWithPagination;
using ResumeApp.Application.Contacts.Queries.GetContactsWithPagination;
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
        _configuration = new MapperConfiguration(config => config.AddMaps(Assembly.GetAssembly(typeof(IApplicationDbContext))));
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
    [TestCase(typeof(Experience), typeof(ExperienceDto))]
    [TestCase(typeof(Skill), typeof(SkillDto))]
    public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        var instance = GetInstanceOf(source);
        _mapper.Map(instance, source, destination);
    }

    private static object GetInstanceOf(Type type)
    {
        // If a parameterless constructor exists, use it
        var ctor = type.GetConstructor(Type.EmptyTypes);
        if (ctor != null)
            return Activator.CreateInstance(type)!;

        // Find a constructor with the fewest parameters and invoke it with default values
        var constructors = type.GetConstructors();
        if (constructors.Length == 0)
            throw new InvalidOperationException($"No constructors found for {type}.");

        ctor = constructors.OrderBy(c => c.GetParameters().Length).First();
        var parameters = ctor.GetParameters()
            .Select(p => p.ParameterType.IsValueType ? Activator.CreateInstance(p.ParameterType) : null)
            .ToArray();

        return ctor.Invoke(parameters);
    }
}
