using ResumeApp.Application.Certificates.Commands.CreateCertificate;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.FunctionalTests.Support.Builders;

public class CreateCertificateCommandBuilder
{
    private string _name = "ACME Cloud Architect";
    private string _issuer = "ACME";
    private Uri _verificationUrl = new("https://theuselessweb.site/nooooooooooooooo/");
    private DateOnly _issueDate = new(1977, 05, 25);
    private DateOnly _expirationDate = new(2005,05,19);
    
    public CreateCertificateCommandBuilder WithName(string name)
    {
        _name = name;
        return this;
    }
    
    public CreateCertificateCommandBuilder WithIssuer(string issuer)
    {
        _issuer = issuer;
        return this;
    }
    
    public CreateCertificateCommandBuilder WithVerificationUrl(Uri verificationUrl)
    {
        _verificationUrl = verificationUrl;
        return this;
    }
    
    public CreateCertificateCommandBuilder WithIssueDate(DateOnly issueDate)
    {
        _issueDate = issueDate;
        return this;
    }
    
    public CreateCertificateCommandBuilder WithExpirationDate(DateOnly expirationDate)
    {
        _expirationDate = expirationDate;
        return this;
    }
    
    public CreateCertificateCommand Build()
    {
        return new CreateCertificateCommand(
            _name,
            _issuer,
            _verificationUrl, 
            _issueDate,
            _expirationDate);
    }
}
