using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nimap\Desktop\serialization_emp_data\sampleData.txt";
            string pathToCreateNewFile = @"C:\Users\Nimap\Desktop\serialization_emp_data\sampleDataCreateFile.txt";
            string jsonpath = @"C:\Users\Nimap\Desktop\serialization_emp_data\sampleData.json";

            // Create employeeData object
            employeeData emp = new employeeData(212, "Amit Mishra");

            // Binary Serialization
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine($"Binary file created successfully at: {path}");

            // Binary De-Serialization
            stream = new FileStream(path, FileMode.Open);
            employeeData emp2 = (employeeData)bf.Deserialize(stream);
            stream.Close();
            Console.WriteLine($"Deserialized Binary Data: Id = {emp2.Id}, Name = {emp2.empName}");


            //JSON Serialization
            string json = JsonConvert.SerializeObject(emp);
            File.WriteAllText(jsonpath, json);
            Console.WriteLine($"JSON file created successfully at: {jsonpath}");

            //JSON De-Serialization
            string jsondatafromfile = File.ReadAllText(jsonpath);
            employeeData deserializedData = JsonConvert.DeserializeObject<employeeData>(jsondatafromfile);

            Console.WriteLine($"Deserialized Json Data: Id = {deserializedData.Id}, Name = {deserializedData.empName}");

            using (FileStream fs = File.Create(pathToCreateNewFile))
            {
                Console.WriteLine($"file created sucessfully at :{pathToCreateNewFile}");
            }

            Console.ReadLine();



        }
    }
}
