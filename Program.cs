using modul7_kelompok_1;

class Program
{
    static void Main(string[] args)
    {
        var DataSteven = new DataMahasiswa103022300155();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        DataSteven.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        var TeamSteven = new TeamMembers103022300155();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        TeamSteven.ReadJSON();
        Console.WriteLine("Proses selesai.\n");
    }
}