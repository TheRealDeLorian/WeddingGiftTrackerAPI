using FluentAssertions;
using System.Net.Http.Json;
using WeddingGiftTrackerAPI.Data.Models;

namespace WeddingGiftTrackerTests;

public class GiftIntegrationTests : IClassFixture<WeddingGiftTrackerApiWebApplicationFactory>
{
    private readonly HttpClient httpClient;

    public GiftIntegrationTests(WeddingGiftTrackerApiWebApplicationFactory factory)
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
    }

    [Fact]
    public async Task AddingGiftWithLetterAsIdReturnsAnError()
    {
        var response = await httpClient.GetAsync("/v1/gift/a");
        await response.Content.ReadAsStringAsync();
        response.IsSuccessStatusCode.Should().BeFalse();

    }
}
