namespace WeddingGiftTrackerTests;

public class UnitTest1
{
    [Fact]

    public async Task CanCallApi()
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7085")
        };
        
        var response = await httpClient.GetAsync("/v1/gift");
        var result = await response.Content.ReadAsStringAsync();
        Assert.True(response.IsSuccessStatusCode);
        //response.IsSuccessStatusCode.Should().BeTrue();
    }
}