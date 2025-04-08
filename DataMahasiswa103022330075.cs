using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_1
{
    class DataMahasiswa103022330075
    {
        public class Mahasiswa
        {
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address Address { get; set; }
            
        }
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }
        public void ReadJSOn()
        {
            string path = "jurnal7_1_103022330075.json";

            try
            {
                string jsonData = File.ReadAllText(path);
                Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(JsonData);
                Console.WriteLine($"Nama: {data.firstname}{data.lastname}");
                Console.WriteLine($"Gender : {data.gender}");
                Console.WriteLine($"Umur : {data.age}");
                Console.WriteLine($"Alamat : {data.Address.streetAddress}, {data.city}, {data.state}");
            }
            catch(Exception e)
            {
                Console.WriteLine("terjadi kesalahan saat membaca file JSON");
                Console.WriteLine(e.Message);
            }
        }
    }
}
