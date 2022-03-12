using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;



namespace XMLfileReader.obj  {
    [XmlRoot(ElementName="record")]
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
    public IList<Record> getAllRecords(){
        return new List<Record>(){

        };
    }














}