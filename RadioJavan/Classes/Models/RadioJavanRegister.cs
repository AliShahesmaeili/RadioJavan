using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RadioJavan.Classes.Models
{
    public class RadioJavanRegister
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        [JsonPropertyName("redirect")]
        public string Redirect { get; set; }
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
        [JsonPropertyName("msg")]
        public string Message { get; set; }
    }
}
