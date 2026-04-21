using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace modul7_kelompok_2
{
    internal class DataMahasiswa103082430002
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Alamat address { get; set; }
        public List<MataKuliah> courses { get; set; }

        public void ReadJSON()
        {
            // membaca file json
            string jsonString = File.ReadAllText("jurnal7_1_103082430002.json");
            // deserialisasi file json
            DataMahasiswa103082430002 data = JsonSerializer.Deserialize<DataMahasiswa103082430002>(jsonString);

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

    // inisialisasi kelas kelas untuk menampung data json
    internal class Alamat
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    internal class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}