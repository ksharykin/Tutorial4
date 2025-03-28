using Tutorial4Classwork.Application;

var clientService = new ClientService();

Console.WriteLine($"Average balance: {clientService.CalculateAverageBalance()}");
var client = clientService.FindClientWithMaxBalance();
Console.WriteLine($"Person with biggest balance: {client.Fullname}");