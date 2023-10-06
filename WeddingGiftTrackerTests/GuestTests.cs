using FluentAssertions;
using System.Net.Http.Json;
using WeddingGiftTrackerAPI.Data.Models;

namespace WeddingGiftTrackerTests;

public class GuestTests : IClassFixture<WeddingGiftTrackerApiWebApplicationFactory>
{
    private readonly HttpClient httpClient;

    public GuestTests(WeddingGiftTrackerApiWebApplicationFactory factory)
    {
        httpClient = factory.CreateDefaultClient();
    }


    [Fact]
    public async Task CanCallApi()
    {
        var response = await httpClient.GetAsync("/v1/guest/1");
        await response.Content.ReadAsStringAsync();
        Assert.True(response.IsSuccessStatusCode);

        var guest1 = await httpClient.GetFromJsonAsync<Guest>("/v1/guest/1");
        guest1.Should().BeEquivalentTo(new Guest
        {
            Id = 1,
            GuestName = "Pete Davidson",
            Address = "234 dsfdsa street"
        });

    }
}
