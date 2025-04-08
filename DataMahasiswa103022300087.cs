using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class DataMahasiswa103022300087
{
    class Address
    {
        public string streetAddress { get; set; }
        public string state { get; set; }
        public string city { get; set; }

    }

    class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Courses> courses { get; set; }
    }

    public void ReadJSON()
    {
        string filePath = "jurnal7_1_103022300087.json";
        string jsonData = File.ReadAllText(filePath);
        var data = JsonSerializer.Deserialize<Mahasiswa>(jsonData);
        Console.WriteLine("-----Data Mahasiswa-----");
        Console.WriteLine($"Nama: {data.firstName} {data.lastName}");
        Console.WriteLine($"Jenis Kelamin: {data.gender}");
        Console.WriteLine($"Umur: {data.age}");
        Console.WriteLine($"Alamat: {data.address.streetAddress}, {data.address.state}, {data.address.city}");
        Console.WriteLine("Mata Kuliah Yang Diambil: ");
        foreach (var course in data.courses)
        {
            Console.WriteLine($"{course.code} - {course.name}");
        }
    }
}
