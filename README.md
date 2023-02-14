# Resume API 
[![Build and deploy](https://github.com/mickey-krasilnikov/resume-backend-netcore/actions/workflows/main_app-resumeapp-api.yml/badge.svg)](https://github.com/mickey-krasilnikov/resume-backend-netcore/actions/workflows/main_app-resumeapp-api.yml)

This is a .NET Core 7 web API that provides the resume information. 
The purpose of the project is to demonstrate knowledge in .Net Core and use it on web frontend.
It has the following controllers:

- Certification
- Contacts
- Education
- Experience
- Skills

Additionally, there is a health endpoint that can be used to check the status of the API.

## Getting Started

To get started with this API, you'll need to have the following installed on your machine:

- .NET Core 7
- Visual Studio or Visual Studio Code

Once you have the requirements set up, follow these steps to run the API locally:

1. Clone the repository to your machine
2. Navigate to the root folder of the project in your terminal
3. Run the command `dotnet restore` to restore the dependencies
4. Run the command `dotnet run` to start the API
5. The API will be running at `http://localhost:7211' or 'http://localhost:5211`

You can use the OpenAPI specification to see the available endpoints and request/response models for the API. The specification is available at the `/swagger` endpoint when the API is running.

