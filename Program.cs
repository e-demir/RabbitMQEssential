using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory();
factory.Uri = new Uri("amqps://rgyiucoc:wOBEPVRcVoj0i0h0Kvy-xwX-RAzZYpXw@stingray.rmq.cloudamqp.com/rgyiucoc");

using var connection = factory.CreateConnection();

var channel = connection.CreateModel();

channel.QueueDeclare("macos-queue", true, false, false);

string message = "This is from Macos";

var messsageBody = Encoding.UTF8.GetBytes(message);

channel.BasicPublish(string.Empty, "macos-queue", null, messsageBody);

Console.WriteLine("Mesaj iletildi.");
Console.ReadLine();