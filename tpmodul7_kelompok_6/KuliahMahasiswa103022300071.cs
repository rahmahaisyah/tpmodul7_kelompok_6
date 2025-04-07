﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tpmodul7_kelompok_6
{
    class KuliahMahasiswa103022300071
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class MataKuliah
        {
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            try
            {
                string filePath = "tp7_2_103022300071.json";
                string jsonContent = File.ReadAllText(filePath);

                MataKuliah data = JsonConvert.DeserializeObject<MataKuliah>(jsonContent);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int i = 1;
                foreach (Course c in data.courses)
                {
                    Console.WriteLine("MK " + i + " " + c.code + " - " + c.name);
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + e.Message);
            }
        }
    }
}
