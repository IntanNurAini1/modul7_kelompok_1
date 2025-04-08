using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_1
{
    class teamMembers103022330075
    {
        public class team
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public int nim { get; set; }
        }
        public List<team>members { get; set; }

        public void ReadJSON()
        {
            string path = "jurnal7_2_103022330075.json";
            try
            {
                string jsonData = File.ReadAllText(path);
                var data = JsonSerializer.Deserialize<teamMembers103022330075>(jsonData);

                Console.WriteLine("Daftar member : ");
                for(int i=0; i < data.members.Count; i++)
                {
                    Console.WriteLine($"{i + 1}{data.member[i].firstName}-{data.member[i].lastName}-{data.member[i].gender}-{data.member[i].age}-{data.member[i].nim}");
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"eror : {ex.Message}");
            }
        }
    }
}
