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

}
    
    static void Main(string[] args){
        Program t = new Program();
       t.DeserializeObject("testcase.xml");


        XmlSerializer serializer = new XmlSerializer(typeof(Root));
        using (StringReader reader = new StringReader(xml)){
        var test = (Root)serializer.Deserialize(reader);
 }
 Console.WriteLine(test);
    }

     async void DeserializeObject(string filename){
 
        // Read a purchase order.
        Console.WriteLine("Reading with Stream");
        // Create an instance of the XmlSerializer.
        XmlSerializer serializer =
        new XmlSerializer(typeof(Root));


        // Declare an object variable of the type to be deserialized.
        Root i;

        using (Stream reader = new FileStream(filename, FileMode.Open))
            // Call the Deserialize method to restore the object's state.
            i = (Root)serializer.Deserialize(reader);
        

        // Write out the properties of the object.
        // Console.WriteLine(i.Name[1] + i.Value);
        Console.WriteLine(test);
        // Debtor + "\t" +
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
