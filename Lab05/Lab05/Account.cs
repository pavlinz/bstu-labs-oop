using System;
using System.Xml.Serialization;

namespace Lab05
{
    [Serializable]
    [XmlRoot(Namespace = "Lab05")]
    [XmlType("account")]
    public class Account
    {
        [XmlElement(ElementName = "Number")]
        public string Number { get; set; }

        [XmlElement(ElementName = "Type Of Deposit")]
        public string TypeOfDeposit { get; set; }

        [XmlElement(ElementName = "Balance")]
        public int Balance { get; set; }

        [XmlElement(ElementName = "Creating Date")]
        public string CreatingDate { get; set; }

        [XmlElement(ElementName = "sms Alert")]
        public bool smsAlert { get; set; }
    }
}
