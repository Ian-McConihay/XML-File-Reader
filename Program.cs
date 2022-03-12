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
using static XMLfileReader.obj.Record;

namespace XMLfileReader{
    
    class Program {
        static void Main(string[] args){
            
            IList<Record> records = new List<Record>();
            
            string path = Path.Combine(Environment.CurrentDirectory, "testcase.xml");

            XmlSerializer xs = new XmlSerializer(typeof(List<Record>));

            using(FileStream stream = File.Open(path, FileMode.Open)){
                records = (List<Record>)xs.Deserialize(stream);
            }




            // string sourceFolderPath ="D:\Kaushik\AllFiles"  
  
            if (Directory.Exists(path))  
            {  
                DirectoryInfo dirSource = new DirectoryInfo(path);  
                var allXMLFiles = dirSource.GetFiles("*.xml", SearchOption.AllDirectories).ToList();  
            
                List<Record> listAllRecordss = new List<Record>();  
            
                foreach (var nextFile in allXMLFiles)  
                {  
                    try  
                    {  
                        XmlSerializer serializer = new XmlSerializer(typeof(Record));  
                        using (TextReader reader = new StringReader(System.IO.File.ReadAllText(nextFile.FullName)))  
                        {  
                            Record result = (Record)serializer.Deserialize(reader);  
                            listAllRecordss.Add(result);  
                        }  
                    }  
                    catch (Exception ex)  
                    {  
            
                    }  
                }  
            } 

        



   Test t = new Test();
        // Read a purchase order.
        t.DeserializeObject("simple.xml");
    

     void DeserializeObject(string filename){
        Console.WriteLine("Reading with Stream");
        // Create an instance of the XmlSerializer.
        XmlSerializer serializer =
        new XmlSerializer(typeof(OrderedItem));

        // Declare an object variable of the type to be deserialized.
        OrderedItem i;

        using (Stream reader = new FileStream(filename, FileMode.Open)){
            // Call the Deserialize method to restore the object's state.
            i = (OrderedItem)serializer.Deserialize(reader);
        }

        // Write out the properties of the object.
        Console.Write(
        i.ItemName + "\t" +
        i.Description + "\t" +
        i.UnitPrice + "\t" +
        i.Quantity + "\t" +
        i.LineTotal);
    


        


    }
        }
    }
}