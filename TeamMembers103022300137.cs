using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}

class TeamMembers103022300137
{
    public List<member> members { get; set; }

    public void readJSON() 
    {
        try
        {
            string path = "jurnal7_2_103022300137.json";
            string jsonString = File.ReadAllText(path);

            TeamMembers103022300137 mhs = JsonSerializer.Deserialize<TeamMembers103022300137>(jsonString);

            Console.WriteLine("Anggota Kelompok:");
            foreach (var member in mhs.members)
            {
                Console.WriteLine("Nama Depan: " + member.firstName);
                Console.WriteLine("Nama Belakang: " + member.lastName);
                Console.WriteLine("Gender: " + member.gender);
                Console.WriteLine("Umur: " + member.age);
                Console.WriteLine("NIM: " + member.nim + "\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca JSON: " + ex.Message);
        }
    }
}


