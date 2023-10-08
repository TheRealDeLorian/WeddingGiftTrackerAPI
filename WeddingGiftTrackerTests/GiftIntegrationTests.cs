using FluentAssertions;
using System.Net.Http.Json;

namespace WeddingGiftTrackerTests;

public class GiftIntegrationTests : IClassFixture<WeddingGiftTrackerApiWebApplicationFactory>
{
    private readonly HttpClient httpClient;

    public GiftIntegrationTests(WeddingGiftTrackerApiWebApplicationFactory factory)
    {
        httpClient = factory.CreateDefaultClient();
    }


    [Fact(DisplayName = "Get gift")]
    public async Task CanCallApi()
    {
        var gift = await httpClient.GetFromJsonAsync<GiftDTO>("/v1/gift/1");
        gift.Should().BeEquivalentTo(new GiftDTO
        {
            GiftName = "Record player",
            Description = "A record player that plays records",
            GiftType = "Misc."
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
