using System;
using System.IO;
using System.IO.Pipes;

class PipeSender
{
    static void Main(string[] message)
    {
        using var server = new NamedPipeServerStream ("BigPipe");
        server.WaitForConnection();

        using var writer = new StreamWriter(server);
        writer.WriteLine("message from sender");
        writer.Flush();
    }
}