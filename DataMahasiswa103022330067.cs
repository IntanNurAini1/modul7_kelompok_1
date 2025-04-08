using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Text.Json;
using System.Threading.Tasks;
public class Add
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
class DataMahasiswa103022330067
{


    public class DataMahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        public Add address { get; set; }
        public List<course> courses { get; set; }
        
    }
    public void readJSON()
    {
        string path = "jurnal7_1_103022330067.json";
        string jsonString = File.ReadAllText(path);
        var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);
        Console.WriteLine($"Nama Depan: { dataMahasiswa.firstName}");
        Console.WriteLine($"Nama Belakang:  {dataMahasiswa.lastName}");
        Console.WriteLine($"gender : {dataMahasiswa.gender}");
        Console.WriteLine($"Alamat : {dataMahasiswa.address.streetAddress}, {dataMahasiswa.address.city}, {dataMahasiswa.address.state}");
        foreach (var course in dataMahasiswa.courses)
        {
            Console.WriteLine($"Kode Mata Kuliah: {course.code}");
            Console.WriteLine($"Nama Mata Kuliah: {course.name}");
        }
    }
}