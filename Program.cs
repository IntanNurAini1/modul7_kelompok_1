class program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300137 DataGumi = new DataMahasiswa103022300137();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        DataGumi.readJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data anggota kelompok...");
        TeamMembers103022300137 teamGumi = new TeamMembers103022300137();
        teamGumi.readJSON();
        Console.WriteLine("Proses selesai.\n");
        Console.WriteLine("============================================\n");

        Console.WriteLine("Memulai proses membaca data glossary...");
        GlossaryItem103022300137 glossGumi = new GlossaryItem103022300137();
        glossGumi.readJSON();
        Console.WriteLine("Proses selesai.\n");
        Console.WriteLine("============================================\n");

    }
}