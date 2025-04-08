using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class TeamMembers103022300087
{
    class Members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    class ListMembers
    {
        public List<Members> members { get; set; }
    }

    public void ReadJSON()
    {
        string filePath = "jurnal7_2_103022300087.json";
        string jsonData = File.ReadAllText(filePath);
        var data = JsonSerializer.Deserialize<ListMembers>(jsonData);
        Console.WriteLine("Team Member List:");
        foreach (var member in data.members)
        {
            Console.WriteLine($"{member.nim} - {member.firstName} {member.lastName} - ({member.age}, {member.gender})");
        }
    }
}

