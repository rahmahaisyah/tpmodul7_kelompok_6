using System;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace tpmodul7_kelompok_6
{
    public class Nama
    {
        public string depan{ get; set; }
        public string belakang { get; set; }
    }
    public class Mahasiswa
    {
        public Nama nama { get; set; } // << nested object di sini
        public long nim { get; set; }
        public string fakultas { get; set; }
    }
    class DataMahasiswa103022300014
    {
        public static void ReadJSON()
        {
            //path file json
            string filePath = "tp7_1_103022300014.json";

            //baca isi file
            string jsonString = File.ReadAllText(filePath);

            //deserialisasi ke object mahasiswa
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            //cetak format
            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan " +
                $"nim {data.nim} dari fakultas {data.fakultas}");
        }
    }
}
