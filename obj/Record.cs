using System;
using System.IO;
using System.Xml.Serialization;
namespace XMLfileReader.obj {
    // This is the class that will be deserialized.
    @XmlRootElement(name = )
    public class Record{
        [XmlElement(Namespace = "testcase.xml")]
        public string Debtor;
    }




    public Record Deserialize(String fileName){
        XmlSerializer serializer = new XmlSerializer
    }
}