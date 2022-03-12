using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;



namespace XMLfileReader.obj {
    public class Record {
        public string Debtor { get; set; }
        public long DebtorSSN { get; set; }
        public string DebtorAddress1 { get; set; }
        public string DebtorAddress2 { get; set; }
        public string DebtorAddress3 { get; set; }
        public string DebtorCounty { get; set; }
        public string DebtorEMail { get; set; }
        public string DebtorDateofBirth { get; set; }
        public string DebtorCellPhone { get; set; }
        public string Spouse { get; set; }
        public string SpouseSSN { get; set; }
        public string SpouseAddress1 { get; set; }
        public string SpouseAddress2 { get; set; }
        public string SpouseAddress3 { get; set; }
        public string DebtorCounty { get; set; }
        public string SpouseEMail { get; set; }
        public string SpouseDateofBirth { get; set; }
        public string SpouseCellPhone { get; set; }
        public string Chapter { get; set; }
        public string TypeofDebtor { get; set; }
        public string AttorneyBarId { get; set; }
        public string IsActive { get; set; }

    }
    public IList<Record> getAllRecords(){
        return new List<Record>(){

        };
    }














}