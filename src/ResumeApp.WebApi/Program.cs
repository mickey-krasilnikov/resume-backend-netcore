using ResumeApp.BusinessLogic.Extensions;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

#if DEBUG
builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly());
#endif

builder.Services.AddResponseCaching();

builder.Services
	.AddControllers(setupAction => setupAction.ReturnHttpNotAcceptable = true)
	.AddJsonOptions(o => o.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);

builder.Services
	.AddEndpointsApiExplorer()
	.AddSwaggerGen()
	.AddResumeServices(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
