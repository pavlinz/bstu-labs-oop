using System;
using System.Xml.Serialization;

namespace Lab05
{
    [Serializable]
    [XmlRoot(Namespace = "Lab05")]
    [XmlType("account")]
    public class Account : ICloneable
    {
        public Owner owner;

        public Account()
        {
            owner = new Owner();
        }

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

        public object Clone()
        {
            Owner bufOwner = new Owner
            {
                FullName = this.owner.FullName,
                DateOfBitrh = this.owner.DateOfBitrh,
                Tel = this.owner.Tel
            };

            return new Account
            {
                Number = this.Number,
                TypeOfDeposit = this.TypeOfDeposit,
                Balance = this.Balance,
                CreatingDate = this.CreatingDate,
                smsAlert = this.smsAlert,
                owner = bufOwner
            };
        }
    }
}
