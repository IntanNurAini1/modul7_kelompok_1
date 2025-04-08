using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class GlossaryItem103022300087
{
    class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
    }

    class GlossDef
    {
        public string para { get; set; }
        public string GlossSeeAlso { get; set; }
        public string GlossSee { get; set; }
    }

    class Glossary
    {
        public GlossEntry entry { get; set; }
        public GlossDef Def { get; set; }
    }
    public void ReadJSON()
    {
        string filePath = "jurnal7_3_103022300087.json";
        string jsonData = File.ReadAllText(filePath);
        var data = JsonSerializer.Deserialize<Glossary>(jsonData);
        Console.WriteLine("-----Glosarry-----");
    }
}
