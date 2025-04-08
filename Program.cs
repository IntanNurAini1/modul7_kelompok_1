using System;

class Program
{
    static void Main(string[] args)
    {
        var dataAgung = new DataMahasiswa103022300087();
        dataAgung.ReadJSON();
        Console.WriteLine("\n");
        var memberAgung = new TeamMembers103022300087();
        memberAgung.ReadJSON();
    }
}