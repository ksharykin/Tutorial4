using Tutorial4Classwork.Models;

namespace Tutorial4Classwork.Application;

public class ClientService
{
    private List<Client> _clients;

    public ClientService()
    {
        _clients =
        [
            new Client
            {
                Fullname = "Alice Brown",
                Balance = new decimal(10000.53)
            },
            new Client
            {
                Fullname = "John Smith",
                Balance = 5703.31m
            },
            new Client
            {
                Fullname = "Conrad Miller",
                Balance = 1213.41m
            }
        ];
    }

    public decimal CalculateAverageBalance() => _clients.Average(c => c.Balance);

    public Client FindClientWithMaxBalance()
    {
        var maxBalance = _clients.Max(c => c.Balance);
        return _clients.First(c => c.Balance == maxBalance);
    }
}