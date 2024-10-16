using System.Net;
using System.Net.Sockets;
using System.Text;

var port = 5000;

var server = new TcpListener(IPAddress.Loopback, port);

server.Start();

Console.WriteLine($"Server started on port {port}");

while (true)
{

  var client = server.AcceptTcpClient();
  Console.WriteLine("client connected");

  var stream = client.GetStream();

  var buffer = new byte[1024];

  stream.Read(buffer);

  var msg = Encoding.UTF8.GetString(buffer);

  Console.WriteLine($"Message from client: {msg}");

}