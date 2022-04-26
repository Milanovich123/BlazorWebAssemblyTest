using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorProject.Shared.ResponseClasses
{
    public class SitelocationResponse
    {
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }
    }
}
