using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class GlossDef
{
    public string para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef GlossDef { get; set; }
    public string GlossSee { get; set; }
}

public class GlossList
{
    public List<GlossEntry> GlossEntry { get; set; }
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; }
}

public class Glossary
{
    public string title { get; set; }
    public string GlossDiv { get; set; }
}

class GlossaryItem103022300137
{
    public Glossary glossary { get; set; }

    public void readJSON()
    {
        try
        {
            string path = "jurnal7_3_103022300137.json";
            string jsonString = File.ReadAllText(path);
            Glossary glossaryItem = JsonSerializer.Deserialize<Glossary>(jsonString);

            var entry = GlossaryItem103022300137.Glossary.GlossDiv.GlossList.GlossEntry;
            Console.WriteLine("ID: " + entry.ID);
            Console.WriteLine("Term: " + entry.GlossTerm);
            Console.WriteLine("Acronym: " + entry.Acronym);
            Console.WriteLine("Abbrev: " + entry.Abbrev);
            Console.WriteLine("Definisi: " + entry.GlossDef.para);
            Console.WriteLine("GlossSee: " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
            Console.WriteLine("GlossSee: " + entry.GlossSee);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca JSON: " + ex.Message);
        }
    }
}


