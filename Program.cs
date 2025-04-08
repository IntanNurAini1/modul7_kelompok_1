
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        var dataAgung = new DataMahasiswa103022300087();
        dataAgung.ReadJSON();
        Console.WriteLine("\n");
        var memberAgung = new TeamMembers103022300087();
        memberAgung.ReadJSON();
        Console.WriteLine("\n");
        var glossaryAgung = new GlossaryItem103022300087();
        glossaryAgung.ReadJSON();
        
        DataMahasiswa103022300137 DataGumi = new DataMahasiswa103022300137();
        Console.WriteLine("\n\nMemulai proses membaca data mahasiswa...");
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