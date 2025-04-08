using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


class DataMahasiswa103022300137
{
    public class address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class dataMahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string age { get; set; }

        public address address { get; set; }
        public List<course> courses { get; set; }
        public void readJSON()
        {
            try
            {
                string path = "jurnal7_1_103022300137.json";
                string jsonString = File.ReadAllText(path);

                dataMahasiswa mhs = JsonSerializer.Deserialize<dataMahasiswa>(json);

                Console.WriteLine("Nama Depan: " + mhs.firstName);
                Console.WriteLine("Nama Belakang: " + mhs.lastName);
                Console.WriteLine("Gender: " + mhs.gender);
                Console.WriteLine("Umur: " + mhs.age + "\n");

                Console.WriteLine("Alamat:");
                Console.WriteLine("Jalan: " + mhs.address.streetAddress);
                Console.WriteLine("Kota: " + mhs.address.city);
                Console.WriteLine("Provinsi: " + mhs.address.state + "\n");

                Console.WriteLine("Mata Kuliah:");
                foreach (var course in mhs.courses)
                {
                    Console.WriteLine("Kode: " + course.code);
                    Console.WriteLine("Nama: " + course.name + "\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal membaca JSON: " + ex.Message);
            }
        }
    }
}

