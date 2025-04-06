using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_6
{
    class DataMahasiswa103022300072
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public string nim { get; set; }
            public string fakultas { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "tp7_1_103022300072.json"; 

            try
            {
                string jsonContent = File.ReadAllText(filePath);
                Mahasiswa mhs = JsonConvert.DeserializeObject<Mahasiswa>(jsonContent);
                Console.WriteLine("Nama " + mhs.nama.depan + " " + mhs.nama.belakang + " dengan nim " + mhs.nim + " dari fakultas " + mhs.fakultas);
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + e.Message);
            }
        }
    }
}
