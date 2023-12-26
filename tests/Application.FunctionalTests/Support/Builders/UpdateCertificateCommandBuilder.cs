using ResumeApp.Application.Certificates.Commands.UpdateCertificate;

namespace ResumeApp.Application.FunctionalTests.Support.Builders;

public class UpdateCertificateCommandBuilder
{
    private Guid _id = Guid.NewGuid();
    private string _name = "ACME Cloud Architect";
    private string _issuer = "ACME";
    private Uri _verificationUrl = new("https://theuselessweb.site/nooooooooooooooo/");
    private DateOnly _issueDate = new(1977, 05, 25);
    private DateOnly _expirationDate = new(2005,05,19);
    
    public UpdateCertificateCommandBuilder WithId(Guid id)
    {
        _id = id;
        return this;
    }
    
    public UpdateCertificateCommandBuilder WithName(string name)
    {
        _name = name;
        return this;
    }
    
    public UpdateCertificateCommandBuilder WithIssuer(string issuer)
    {
        _issuer = issuer;
        return this;
    }
    
    public UpdateCertificateCommandBuilder WithVerificationUrl(Uri verificationUrl)
    {
        _verificationUrl = verificationUrl;
        return this;
    }
    
    public UpdateCertificateCommandBuilder WithIssueDate(DateOnly issueDate)
    {
        _issueDate = issueDate;
        return this;
    }
    
    public UpdateCertificateCommandBuilder WithExpirationDate(DateOnly expirationDate)
    {
        _expirationDate = expirationDate;
        return this;
    }
    
    public UpdateCertificateCommand Build()
    {
        return new UpdateCertificateCommand(
            _id,
            _name,
            _issuer,
            _verificationUrl, 
            _issueDate,
            _expirationDate);
    }
}
