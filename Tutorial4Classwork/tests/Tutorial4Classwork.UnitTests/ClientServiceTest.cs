using JetBrains.Annotations;
using Tutorial4Classwork.Application;
using Tutorial4Classwork.Models;

namespace Tutorial4Classwork.UnitTests;

[TestSubject(typeof(ClientService))]
public class ClientServiceTest
{
    private ClientService clientService = new();

    [Fact]
    public void CalculateAverage_Test()
    {
        var expectedValue = 5639.0833333333333333333333333m;
        var actualValue = clientService.CalculateAverageBalance();
        
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void FindClientWithMaxBalance_Test()
    {
        Client expectedClient = new()
        {
            Fullname = "Alice Brown",
            Balance = new decimal(10000.53)
        };
        Client actualClient = clientService.FindClientWithMaxBalance();
        
        Assert.True(string.Equals(expectedClient.Fullname, actualClient.Fullname));
    }
}