﻿using System.Data.Common;
using ResumeApp.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Respawn;

namespace ResumeApp.Application.FunctionalTests;

public class SqlServerTestDatabase : ITestDatabase
{
    private readonly string _connectionString;
    private SqlConnection _connection = null!;
    private Respawner _respawner = null!;

    public SqlServerTestDatabase()
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        Guard.Against.Null(connectionString);
        _connectionString = connectionString;
    }

    public async Task InitialiseAsync()
    {
        _connection = new SqlConnection(_connectionString);
        
        var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(_connectionString).Options;
        var context = new ApplicationDbContext(options);
        
        await context.Database.MigrateAsync();

        _respawner = await Respawner.CreateAsync(_connectionString, new RespawnerOptions
        {
            TablesToIgnore = ["__EFMigrationsHistory"]
        });
    }

    public DbConnection GetConnection()
    {
        return _connection;
    }

    public async Task ResetAsync()
    {
        await _respawner.ResetAsync(_connectionString);
    }

    public async Task DisposeAsync()
    {
        await _connection.DisposeAsync();
    }
}
