using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
    public GlossEntry GlossEntry { get; set; }  
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; }
}

public class Glossary
{
    public string title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

public class GlossaryItem103022300137
{
    public Glossary glossary { get; set; }

    public void readJSON()
    {
        try
        {
            string path = "jurnal7_3_103022300137.json";
            string jsonString = File.ReadAllText(path);
            GlossaryItem103022300137 data = JsonSerializer.Deserialize<GlossaryItem103022300137>(jsonString);

            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;
            Console.WriteLine("ID: " + entry.ID);
            Console.WriteLine("Term: " + entry.GlossTerm);
            Console.WriteLine("Acronym: " + entry.Acronym);
            Console.WriteLine("Abbrev: " + entry.Abbrev);
            Console.WriteLine("Definisi: " + entry.GlossDef.para);
            Console.WriteLine("GlossSeeAlso: " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
            Console.WriteLine("GlossSee: " + entry.GlossSee);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca JSON: " + ex.Message);
        }
    }
}
