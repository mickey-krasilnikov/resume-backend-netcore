# ResumeApp

## Introduction

ResumeApp is a simple web application developed using .NET 8. It is designed following the clean architecture pattern and serves as a backend RESTful API. This application is an excellent resource for those learning .NET and can be used as a template or reference for building similar applications.

## Build

To build the solution, use the following command:

```bash
dotnet build -tl
````
This will compile the application and prepare it for running or testing.

## Run

To run the web application, follow these steps:

```bash
cd .\src\Web\
dotnet watch run
```
After running the above command, navigate to https://localhost:5001. The application features hot reload, automatically updating as you modify the source files.

## Code Styles & Formatting
To ensure consistency in coding styles across different IDEs and editors, the project uses [EditorConfig](https://editorconfig.org/). The .editorconfig file in the root of the project specifies the coding styles for this solution.

## Test

The ResumeApp includes various types of tests, such as unit tests, integration tests, and functional tests.

To execute these tests, use the following command:
```bash
dotnet test
```
This command will run all the tests included in the solution and provide a summary of the test results.

## Learning Resource

For those new to .NET or looking to understand the clean architecture pattern, ResumeApp serves as an excellent starting point. The codebase is structured and documented in a way that makes it easy for beginners to understand and learn from.