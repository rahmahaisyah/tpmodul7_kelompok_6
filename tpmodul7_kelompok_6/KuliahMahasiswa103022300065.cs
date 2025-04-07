using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_6
{
    class KuliahMahasiswa103022300065
    {
        public class Course
        {
            public string Code { get; set; } = string.Empty;  
            public string Name { get; set; } = string.Empty;
        }

        public class CourseList
        {
            public List<Course> Courses { get; set; }  
        }

        public static void ReadJSON()
        {
            string filePath = "tp7_2_103022300065.json";

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File tidak ditemukan: " + filePath);
                    return;
                }

                string jsonContent = File.ReadAllText(filePath);
              
               

                CourseList? courseList = JsonSerializer.Deserialize<CourseList>(jsonContent);

                if (courseList != null && courseList.Courses != null && courseList.Courses.Count > 0)
                {
                    Console.WriteLine("\nDaftar Mata Kuliah:");
                    foreach (var course in courseList.Courses)
                    {
                        Console.WriteLine($"Kode: {course.Code}, Nama: {course.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("\nData kosong atau format JSON salah.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal membaca file JSON: " + e.Message);
            }
        }

    }
}
