using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace modul7_kelompok_2
{
    // implementasi kelas kelas sebagai tempat penampung data dari json
    internal class GlossaryWrapper
    {
        public GlossaryData glossary { get; set; }
    }

    internal class GlossaryData
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    internal class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    internal class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    internal class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    internal class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    internal class GlossaryItem103082430002
    {
        public void ReadJSON()
        {            
            // membaca file json
            string jsonString = File.ReadAllText("jurnal7_3_103082430002.json");
            // deserialisasi file json
            GlossaryWrapper data = JsonSerializer.Deserialize<GlossaryWrapper>(jsonString);
            // ambil data
            GlossEntry entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("=== DETAIL GLOSS ENTRY ===");
            Console.WriteLine($"ID        : {entry.ID}");
            Console.WriteLine($"Term      : {entry.GlossTerm}");
            Console.WriteLine($"Acronym   : {entry.Acronym}");
            Console.WriteLine($"Abbrev    : {entry.Abbrev}");
            Console.WriteLine($"Definition: {entry.GlossDef.para}");
            Console.WriteLine($"See Also  : {string.Join(", ", entry.GlossDef.GlossSeeAlso)}");
            Console.WriteLine($"See       : {entry.GlossSee}");
            Console.WriteLine("==========================");
        }
    }
}