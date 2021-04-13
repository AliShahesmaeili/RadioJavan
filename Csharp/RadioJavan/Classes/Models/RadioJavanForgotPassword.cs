using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RadioJavan.Classes.Models
{
    public class RadioJavanForgotPassword
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
