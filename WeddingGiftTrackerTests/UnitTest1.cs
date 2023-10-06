using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Net.Http.Json;
using Testcontainers.PostgreSql;
using WeddingGiftTrackerAPI.Data;
using WeddingGiftTrackerAPI.Data.Models;

namespace WeddingGiftTrackerTests;

public class UnitTest1 : IClassFixture<WeddingGiftTrackerApiWebApplicationFactory>
{
    private readonly HttpClient httpClient;

    public UnitTest1(WeddingGiftTrackerApiWebApplicationFactory factory)
    {
        httpClient = factory.CreateDefaultClient();
    }


    [Fact]

    public async Task CanCallApi()
    {
        var response = await httpClient.GetAsync("/v1/gift/1");
        await response.Content.ReadAsStringAsync();
        Assert.True(response.IsSuccessStatusCode);

        var gift1 = await httpClient.GetFromJsonAsync<Gift>("/v1/gift/1");
        gift1.Should().BeEquivalentTo(new Gift
        {
            Id = 1,
            GiftName = "record player"
        });

        //response.IsSuccessStatusCode.Should().BeTrue();
    }
}



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