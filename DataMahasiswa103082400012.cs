using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace modul7_kelompok_2
{
    public class DataMahasiswa103082400012
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Alamat address { get; set; }
        public List<MataKuliah> courses { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103082400012.json");

            DataMahasiswa103082400012 data = JsonSerializer.Deserialize<DataMahasiswa103082400012>(jsonString);

            Console.WriteLine($"Nama Lengkap: {data.firstName} {data.lastName}");
            Console.WriteLine($"Jenis Kelamin: {data.gender}");
            Console.WriteLine($"Umur: {data.age}");
            Console.WriteLine($"Alamat: {data.address.streetAddress}, {data.address.city}, {data.address.state}");
            Console.WriteLine("\nDaftar Mata Kuliah:");

            foreach (var course in data.courses)
            {
                Console.WriteLine($"- {course.code}: {course.name}");
            }
        }
    }

    public class Alamat
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}