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
using System.Xml.Serialization;
// using static XMLfileReader.obj.Record;

namespace XMLfileReader{
    
    public class Program {
  
[XmlRoot(ElementName="field")]
public class Field { 

	[XmlAttribute(AttributeName="Name")] 
	public string? Name { get; set; } 

	[XmlAttribute(AttributeName="Value")] 
	public int? Value { get; set; } 
}

[XmlRoot(ElementName="Root")]
public class Root { 

	[XmlElement(ElementName="field")] 
	public List<Field>? Field { get; set; } 

    
    
    static void Main(string[] args){
         Program t = new Program();
        // Read a purchase order.
        t.DeserializeObject("testcase.xml");
    

     void DeserializeObject(string filename){
        Console.WriteLine("Reading with Stream");
        // Create an instance of the XmlSerializer.
        XmlSerializer serializer =
        new XmlSerializer(typeof(Field));

        // Declare an object variable of the type to be deserialized.
        Field i;

        using (Stream reader = new FileStream(filename, FileMode.Open)){
            // Call the Deserialize method to restore the object's state.
            i = (Field)serializer.Deserialize(reader);
        }

        // Write out the properties of the object.
        // Console.Write(
        // i.Debtor + "\t" +
        // i.DebtorSSN + "\t" +
        // i.DebtorAddress1 + "\t" +
        // i.DebtorAddress2 + "\t" +
        // i.DebtorAddress3 + "\t" +
        // i.DebtorCounty + "\t" +
        // i.DebtorEMail + "\t" +
        // i.DebtorDateofBirth + "\t" +
        // i.DebtorCellPhone + "\t" +
        // i.Spouse + "\t" +
        // i.SpouseSSN + "\t" +
        // i.SpouseAddress1 + "\t" +
        // i.SpouseAddress2 + "\t" +
        // i.SpouseAddress3 + "\t" +
        // i.DebtorCounty + "\t" +
        // i.SpouseEMail + "\t" +
        // i.SpouseDateofBirth + "\t" +
        // i.SpouseCellPhone + "\t" +
        // i.Chapter + "\t" +
        // i.TypeofDebtor + "\t" +
        // i.AttorneyBarId + "\t" +
        // i.IsActive);
    


        
     }

        
        }
    }
}
}