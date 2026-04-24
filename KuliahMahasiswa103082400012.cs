using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_7
{

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    internal class KuliahMahasiswa103082400012
    {
        public List<Course> courses { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("tp7_103082430002.json");
            KuliahMahasiswa103082400012 data = JsonSerializer.Deserialize<KuliahMahasiswa103082400012>(jsonString);

            for (int i = 0; i < data.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {data.courses[i].code} - {data.courses[i].name}");
            }
        }
    }
}