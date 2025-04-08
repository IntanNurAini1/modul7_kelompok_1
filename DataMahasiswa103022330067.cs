using System;
using System.IO;
using System.Text.Json;

public class  DataMahasiswa103022330067
{
   
        public string namad { get; set; }
        public string namab { get; set; }
        public string Alamat { get; set; }
        public int umur { get; set; }
        public List<co> course { get; set; }

    

    public class  co
    {
        public string code { get; set; }
        public string namac { get; set; }
    }

    public void ReadJsonFile()
    {
        string path = "jurnal7_1_103022330067.json";
        try
        {
            string jsonString = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<DataMahasiswa103022330067>(jsonData);
            Console.WriteLine("Nama Depan: " + data.namad);
            Console.WriteLine("Nama Belakang: " + data.namab);
            Console.WriteLine("Alamat: " + data.Alamat);
            Console.WriteLine("Umur: " + data.umur);
            foreach (var course in data.course)
            {
                Console.WriteLine("Kode Course: " + course.code);
                Console.WriteLine("Nama Course: " + course.namac);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading JSON file: " + ex.Message);
        }
    }
}