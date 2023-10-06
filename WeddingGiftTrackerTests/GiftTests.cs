using FluentAssertions;
using System.Net.Http.Json;
using WeddingGiftTrackerAPI.Data.Models;

namespace WeddingGiftTrackerTests;

public class GiftTests : IClassFixture<WeddingGiftTrackerApiWebApplicationFactory>
{
    private readonly HttpClient httpClient;

    public GiftTests(WeddingGiftTrackerApiWebApplicationFactory factory)
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
