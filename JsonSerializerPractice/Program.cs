using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonSerializerPractice
{
    //C:\Users\shuhei.nishizawa\Desktop\testData.json
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input json file path:");

            string filePath = Console.ReadLine();

            string jsonText = File.ReadAllText(filePath);

            var deserialized = JsonConvert.DeserializeObject<StudentList>(jsonText);

            Console.WriteLine(deserialized.Students[2].Name);
        }
    }

    public class StudentList
    {
        public List<Student> Students;
    }

    public class Student
    {
        public string Name;
        public int Age;
    }
}


 