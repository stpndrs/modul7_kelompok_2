using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace modul7_kelompok_2
{
    internal class TeamMembers103082430002
    {
        // inisialisasi list member
        public List<Mahasiswa> members { get; set; }

        public void ReadJSON()
        {
            // membaca file json
            string jsonString = File.ReadAllText("jurnal7_2_103082430002.json");
            // deserialisasi file json
            TeamMembers103082430002 data = JsonSerializer.Deserialize<TeamMembers103082430002>(jsonString);

            Console.WriteLine("Daftar Anggota Kelompok:");
            // menampilkan isi
            foreach (var mhs in data.members)
            {
                Console.WriteLine($"{mhs.nim} {mhs.firstName} {mhs.lastName} ({mhs.age} {mhs.gender})");
            }
        }
    }

    // definisikan atribut di kelas mahasiswa sebagai wadah data dari json
    internal class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
}