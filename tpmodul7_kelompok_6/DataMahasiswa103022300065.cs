using System;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_6
{
    class DataMahasiswa103022300065
    {
        public class Nama
        {
            public string Depan { get; set; }
            public string Belakang { get; set; }
        }

        public class Mahasiswa
        {
            public Nama Nama { get; set; }
            public long Nim { get; set; }
            public string Fakultas { get; set; }
        }

        public static void ReadJSON()
        {

            string filePath = "tp7_1_103022300065.json";

            try
            {
                string jsonContent = File.ReadAllText(filePath);

                

                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonContent);
                Console.WriteLine($"Nama {mhs.Nama.Depan} {mhs.Nama.Belakang} dengan nim {mhs.Nim} dari fakultas {mhs.Fakultas}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal membaca file JSON: " + e.Message);
            }
        }

    }
}
