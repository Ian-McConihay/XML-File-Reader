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
using System.Xml.Linq;
// using static XMLfileReader.obj.Record;

namespace XMLfileReader{
    
    public class Program {
       

            
            
            // IList<Record> records = new List<Record>();
            
            // string path = Path.Combine(Environment.CurrentDirectory, "testcase.xml");

            // XmlSerializer xs = new XmlSerializer(typeof(List<Record>));

            // using(FileStream stream = File.Open(path, FileMode.Open)){
            //     records = (List<Record>)xs.Deserialize(stream);
            // }
            

            

            // string sourceFolderPath ="D:\Kaushik\AllFiles"  
  
            // if (Directory.Exists(path))  {  
            //     DirectoryInfo dirSource = new DirectoryInfo(path);  
            //     var allXMLFiles = dirSource.GetFiles("*.xml", SearchOption.AllDirectories).ToList();  
            
            //     List<Record> listAllRecordss = new List<Record>();  
            
            //     foreach (var nextFile in allXMLFiles)  
            //     {  
            //         try  
            //         {  
            //             XmlSerializer serializer = new XmlSerializer(typeof(Record));  
            //             using (TextReader reader = new StringReader(System.IO.File.ReadAllText(nextFile.FullName)))  
            //             {  
            //                 Record result = (Record)serializer.Deserialize(reader);  
            //                 listAllRecordss.Add(result);  
            //             }  
            //         }  
            //         catch (Exception ex)  
            //         {  
            
            //         }  
            //     }  
            // } 

        


      public class Record {
        [XmlAttribute(AttributeName="Debtor")]
        public string Debtor { get; set; }
        [XmlAttribute(AttributeName="DebtorSSN")]
        public long DebtorSSN { get; set; }
        [XmlAttribute(AttributeName="DebtorAddress1")]
        public string DebtorAddress1 { get; set; }
        [XmlAttribute(AttributeName="DebtorAddress2")]
        public string DebtorAddress2 { get; set; }
        [XmlAttribute(AttributeName="DebtorAddress3")]
        public string DebtorAddress3 { get; set; }
        [XmlAttribute(AttributeName="DebtorCounty")]
        public string DebtorCounty { get; set; }
        [XmlAttribute(AttributeName="DebtorEMail")]
        public string DebtorEMail { get; set; }
        [XmlAttribute(AttributeName="DebtorDateofBirth")]
        public string DebtorDateofBirth { get; set; }
        [XmlAttribute(AttributeName="DebtorCellPhone")]
        public string DebtorCellPhone { get; set; }
        [XmlAttribute(AttributeName="Spouse")]
        public string Spouse { get; set; }
        [XmlAttribute(AttributeName="SpouseSSN")]
        public string SpouseSSN { get; set; }
        [XmlAttribute(AttributeName="SpouseAddress1")]
        public string SpouseAddress1 { get; set; }
        [XmlAttribute(AttributeName="SpouseAddress2")]
        public string SpouseAddress2 { get; set; }
        [XmlAttribute(AttributeName="SpouseAddress3")]
        public string SpouseAddress3 { get; set; }
        [XmlAttribute(AttributeName="DebtorCounty")]
        public string DebtorCounty { get; set; }
        [XmlAttribute(AttributeName="SpouseEMail")]
        public string SpouseEMail { get; set; }
        [XmlAttribute(AttributeName="SpouseDateofBirth")]
        public string SpouseDateofBirth { get; set; }
        [XmlAttribute(AttributeName="SpouseCellPhone")]
        public string SpouseCellPhone { get; set; }
        [XmlAttribute(AttributeName="Chapter")]
        public string Chapter { get; set; }
        [XmlAttribute(AttributeName="TypeofDebtor")]
        public string TypeofDebtor { get; set; }
        [XmlAttribute(AttributeName="AttorneyBarId")]
        public string AttorneyBarId { get; set; }
        [XmlAttribute(AttributeName="IsActive")]
        public string IsActive { get; set; }

    }
   Progam t = new Program();
    static void Main(string[] args){
        // Read a purchase order.
        t.DeserializeObject("testcase.xml");
    

     void DeserializeObject(string filename){
        Console.WriteLine("Reading with Stream");
        // Create an instance of the XmlSerializer.
        XmlSerializer serializer =
        new XmlSerializer(typeof(Record));

        // Declare an object variable of the type to be deserialized.
        Record i;

        using (Stream reader = new FileStream(filename, FileMode.Open)){
            // Call the Deserialize method to restore the object's state.
            i = (Record)serializer.Deserialize(reader);
        }

        // Write out the properties of the object.
        Console.Write(
        i.Debtor + "\t" +
        i.DebtorSSN + "\t" +
        i.DebtorAddress1 + "\t" +
        i.DebtorAddress2 + "\t" +
        i.DebtorAddress3 + "\t" +
        i.DebtorCounty + "\t" +
        i.DebtorEMail + "\t" +
        i.DebtorDateofBirth + "\t" +
        i.DebtorCellPhone + "\t" +
        i.Spouse + "\t" +
        i.SpouseSSN + "\t" +
        i.SpouseAddress1 + "\t" +
        i.SpouseAddress2 + "\t" +
        i.SpouseAddress3 + "\t" +
        i.DebtorCounty + "\t" +
        i.SpouseEMail + "\t" +
        i.SpouseDateofBirth + "\t" +
        i.SpouseCellPhone + "\t" +
        i.Chapter + "\t" +
        i.TypeofDebtor + "\t" +
        i.AttorneyBarId + "\t" +
        i.IsActive);
    


        
    }

        
        }
    }
}