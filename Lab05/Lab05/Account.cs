using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab05
{
    public class Account
    {
        [JsonPropertyName("Number of Account")]
        public string Number { get; set; }

        [JsonPropertyName("Type of Deposit")]
        public string TypeOfDeposit { get; set; }

        [JsonPropertyName("Balance")]
        public int Balance { get; set; }

        [JsonPropertyName("Creating Date")]
        public string CreatingDate { get; set; }

        [JsonPropertyName("SMS alert")]
        public bool smsAlert { get; set; }
    }
}
