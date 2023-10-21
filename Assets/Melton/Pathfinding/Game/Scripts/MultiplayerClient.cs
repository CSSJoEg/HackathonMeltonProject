/* using System;
using Quobject.SocketIoClientDotNet.Client;

class Program
{
    private static Socket socket;
    private static string roomID; // Speichert die ID des Spiels

    static void Main(string[] args)
    {
        socket = IO.Socket("http://localhost:3000"); // Ersetzen Sie die URL durch die Ihres Node.js-Servers

        socket.On(Socket.EVENT_CONNECT, () =>
        {
            Console.WriteLine("Verbunden zum Server");
        });

        socket.On("spielGefunden", (data) =>
        {
            roomID = data.ToString();
            Console.WriteLine("Spiel gefunden. Spiel-ID: " + roomID);
            StarteSpiel();
        });

        Console.WriteLine("Drücken Sie Enter, um nach einem Spiel zu suchen.");
        Console.ReadLine();
    }

    private static void StarteSpiel()
    {
        socket.On("spielzug", (data) =>
        {
            Console.WriteLine("Spielzug erhalten: " + data);
            // Hier können Sie die Logik für die Verarbeitung des Spielzugs implementieren.
        });

        // Hier können Sie Ihren eigenen Spiel-Loop oder Logik implementieren
        // um Spielzüge an den Server zu senden. Zum Beispiel:
        while (true)
        {
            Console.Write("Ihr Spielzug: ");
            string spielzug = Console.ReadLine();
            socket.Emit("spielzug", new { roomID, spielzug });
        }
    }
}
*/
