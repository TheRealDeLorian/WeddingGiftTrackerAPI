using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Testcontainers.PostgreSql;
using WeddingGiftTrackerAPI.Data;

namespace WeddingGiftTrackerTests;

public class WeddingGiftTrackerApiWebApplicationFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private readonly PostgreSqlContainer _dbContainer;
    public WeddingGiftTrackerApiWebApplicationFactory()
    {
        var whereAmI = Environment.CurrentDirectory;
        var backupFile = Directory.GetFiles("../../../..", "*.sql", SearchOption.AllDirectories)
            .Select(f => new FileInfo(f))
            .OrderByDescending(fi => fi.LastWriteTime)
            .First();
        _dbContainer = new PostgreSqlBuilder()
            .WithImage("postgres")
            .WithPassword("Strong_password_123!")
            .WithBindMount(backupFile.FullName, "/docker-entrypoint-initdb.d/init.sql")
            .Build();
    }
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            services.RemoveAll(typeof(DbContextOptions<WeddingGiftDbContext>));
            services.AddDbContext<WeddingGiftDbContext>(options => options.UseNpgsql(_dbContainer.GetConnectionString()));
        });
    }
    public async Task InitializeAsync()
    {
        await _dbContainer.StartAsync();
    }

    async Task IAsyncLifetime.DisposeAsync()
    {
        await _dbContainer.StopAsync();
    }
}