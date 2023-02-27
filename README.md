# Resume App RESTful Web API
[![Build and Deploy to Azure Web App](https://github.com/mickey-krasilnikov/resume-backend-netcore/actions/workflows/main_app-resumeapp-api.yml/badge.svg)](https://github.com/mickey-krasilnikov/resume-backend-netcore/actions/workflows/main_app-resumeapp-api.yml)
![Code Coverage](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/mickey-krasilnikov/8f7365cb925afff5db063ecee4688a55/raw/code-coverage.json)

The Resume App RESTful Web API is a cross-platform web API written in .NET 7 that serves as the backend for a resume application. It enables to manage resume by allowing to create, read, update, and delete the various parts of the resume, including Certifications, Contacts, Education, Experience, and Skills.

## Endpoints

### Health

- `GET /api/resumeservice/Health`
- `HEAD /api/resumeservice/Health`

### Certification

- `OPTIONS /api/resumeservice/Certification`
- `GET /api/resumeservice/Certification`
- `POST /api/resumeservice/Certification`
- `GET /api/resumeservice/Certification/{id}`
- `PUT /api/resumeservice/Certification/{id}`
- `DELETE /api/resumeservice/Certification/{id}`

### Contacts

- `OPTIONS /api/resumeservice/Contacts`
- `GET /api/resumeservice/Contacts`
- `POST /api/resumeservice/Contacts`
- `GET /api/resumeservice/Contacts/{id}`
- `PUT /api/resumeservice/Contacts/{id}`
- `DELETE /api/resumeservice/Contacts/{id}`

### Education

- `OPTIONS /api/resumeservice/Education`
- `GET /api/resumeservice/Education`
- `POST /api/resumeservice/Education`
- `GET /api/resumeservice/Education/{id}`
- `PUT /api/resumeservice/Education/{id}`
- `DELETE /api/resumeservice/Education/{id}`

### Experience

- `OPTIONS /api/resumeservice/Experience`
- `GET /api/resumeservice/Experience`
- `POST /api/resumeservice/Experience`
- `GET /api/resumeservice/Experience/{id}`
- `PUT /api/resumeservice/Experience/{id}`
- `DELETE /api/resumeservice/Experience/{id}`

### Skills

- `OPTIONS /api/resumeservice/Skills`
- `GET /api/resumeservice/Skills`
- `POST /api/resumeservice/Skills`
- `GET /api/resumeservice/Skills/{id}`
- `PUT /api/resumeservice/Skills/{id}`
- `DELETE /api/resumeservice/Skills/{id}`

## To Run Locally

To run the API locally, you can use one of two launch profiles:

1. Cross-platform Kestrel server - This runs on HTTP on port 55360 and HTTPS on an 55361 port.
2. IIS Express - This runs on HTTP on port 46397 and HTTPS on port 44369.

To run the API locally, follow these steps:

1. Open the solution file in Visual Studio.
2. Choose the launch profile you want to use by clicking the "Launch" dropdown in the toolbar and selecting the appropriate profile.
3. Click the "Play" button in the toolbar to start the server.

## Documentation

The API includes Swagger UI and OpenAPI v3 documentation. You can access the Swagger page using the path `/swagger`, and the OpenAPI v3 specification using the path `/swagger/v1/swagger.json`. The OpenAPI specification is generated automatically on every build in debug mode as a post-build event using the `dotnet swagger tofile` command.

## API Client Generation

The API client is automatically generated on every build using the NSwagCSharp code generator based on the OpenAPI specification. To generate the client code manually, you can use the following command:
```
nswag openapi2csclient /input:ResumeAppOpenApiSpecification.json /classname:ResumeApiClient /output:ResumeApiClient.cs
```
This command generates the client code from the OpenAPI specification file `ResumeAppOpenApiSpecification.json`, creates a class called `ResumeApiClient`, and outputs the code to a file called `ResumeApiClient.cs`.

## Testing

The code is covered by unit and contract tests using the xUnit framework. To run tests and generate code coverage information, use the following command:
```
dotnet test /p:CollectCoverage=true
```
This command runs the unit and contract tests and generates code coverage information. You can specify additional parameters, such as the output format and location, by adding them to the command.

You can specify additional parameters by adding them to the `dotnet test` command. Some common parameters include:

- `/p:Exclude=[filter]`: Excludes tests that match the specified filter.
- `/p:Include=[filter]`: Includes only tests that match the specified filter.
- `/p:CoverletOutputFormat=[format]`: Specifies the output format for code coverage information.
- `/p:CoverletOutput=[path]`: Specifies the path to the directory where the code coverage results are stored.
- `/p:CoverletOutputFormat=opencover`: Specifies the output format as OpenCover, which can be used with various third-party tools to generate coverage reports.

For more information about `dotnet test` and its parameters, see the [official documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test).




