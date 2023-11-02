// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");
Client client = new Client(Factory.SqlFactory);
client.Run();
client = new Client(Factory.NpgsqlFactory);
client.Run();