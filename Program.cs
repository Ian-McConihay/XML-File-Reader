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
using System.Xml;

namespace XMLfileReader{
    class Program{
        static void Main(string[] args){
            XmlTextReader xtr = new XmlTextReader("/Users/ianmcconihay/XMLfileReader/testcase.xml");
            while (xtr.Read()){
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "name"){
                    string s1 = xtr.ReadElementString();
                    Console.WriteLine("Name = " + s1);
                }
            }


        }
    }
}