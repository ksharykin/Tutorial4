using Tutorial4Classwork.Application;

var clientService = new ClientService();

Console.WriteLine($"Average balance: {clientService.CalculateAverageBalance()}");
var client = clientService.FindClientWithMaxBalance();
if (client is null)
{
    Console.WriteLine($"Person with biggest balance is not found.");
}
else
{
    Console.WriteLine($"Person with biggest balance: {client.Fullname}");   
}