using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class GlossSeeAlso
{
    public List<string> GlossSeeAlsoList { get; set; }
}

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

public class GlossaryItem103082400014
{
    public Glossary glossary { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_3_103082400014.json");

        var data = JsonSerializer.Deserialize<GlossaryItem103082400014>(json);

        var g = data.glossary.GlossDiv.GlossList.GlossEntry;

        Console.WriteLine("Gloss Entry:");
        Console.WriteLine("ID: " + g.ID);
        Console.WriteLine("Term: " + g.GlossTerm);
        Console.WriteLine("Definition: " + g.GlossDef.para);

        Console.WriteLine("\nSee Also:");
        foreach (var item in g.GlossDef.GlossSeeAlso)
        {
            Console.WriteLine("- " + item);
        }
    }
}