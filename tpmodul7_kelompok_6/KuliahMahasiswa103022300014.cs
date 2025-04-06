using System;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_6
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    class KuliahMahasiswa103022300014
    {
        public static void ReadJSON()
        {
            //path file json
            string filePath = "tp7_2_103022300014.json";

            //baca isi file
            string jsonString = File.ReadAllText(filePath);

            //deserialisasi ke object mahasiswa
            CourseList data = JsonConvert.DeserializeObject<CourseList>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {course.code} - {course.name}");
            }
        }
    }
}
