// Console.WriteLine("Hello, World!");
// Console.WriteLine();
// Console.WriteLine("Input a name");
// string? input = Console.ReadLine();

// Console.WriteLine("How many times do you want to repeat the name");
// string? times = Console.ReadLine();

// for(int i=0; i< Convert.ToInt32(times); i++){
//     Console.WriteLine("Hello "+ input);
// }
using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;

namespace XMLfileReader{
    class Program{
        static void Main(string[] args){
            
            IList<Record> records = new List<Record>();
            
            string path = Path.Combine(Environment.CurrentDirectory, "testcase.xml");

            XmlSerializer xs = new XmlSerializer(typeof(List<Record>));

            using(FileStream stream = File.Open(path, FileMode.Open)){
                records = (List<Record>)xs.Deserialize(stream);
            }
        }
    }
}