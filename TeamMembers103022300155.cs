using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_1.DataMahasiswa103022300155;

namespace modul7_kelompok_1
{
    class TeamMembers103022300155
    {
        public class anggota
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set;  }
            public long nim { get; set; }
        }

        public List<anggota> members { get; set; }
        public void ReadJSON()
        {
            string path = "jurnal7_2_103022300155.json";

            try
            {
                string jsonData = File.ReadAllText(path);
                var data = JsonSerializer.Deserialize<TeamMembers103022300155>(jsonData);

                Console.WriteLine("Nama Member:");
                for (int i = 0; i < data.members.Count; i++)
                {
                    Console.WriteLine($"Nama : {i + 1} {data.members[i].firstName} - {data.members[i].lastName} \nGender : {data.members[i].gender} \nUsia: {data.members[i].age} \nNIM : {data.members[i].nim}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
