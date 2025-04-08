using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok_1
{
    class DataMahasiswa103022300155
    {
        public class Alamat
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class MataKuliah
        {
            public string name { get; set; }
            public string code { get; set; }
        }

        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }

            public Alamat address { get; set; }
            public List<MataKuliah> courses { get; set; }
        }

        public void ReadJSON()
        {
            string path = "jurnal7_1_103022300155.json";

            try
            {
                string jsonData = File.ReadAllText(path);
                Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonData);
                Console.WriteLine($"Nama {data.firstName} {data.lastName} dengan usia {data.age} berjenis kelamin {data.gender}");
                Console.WriteLine($"Jalan ; {data.address.streetAddress}, Kota: {data.address.city}, Provinsi {data.address.state}");
                Console.WriteLine("Daftar mata kuliah yang diambil:");
                for (int i = 0; i < data.courses.Count; i++)
                {
                    Console.WriteLine($"MK {i + 1} {data.courses[i].code} - {data.courses[i].name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
