using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorProject.Shared.ResponseClasses
{
    public class EntityResponse
    {
        [JsonPropertyName("revisionId")]
        public string RevisionId { get; set; }

        [JsonPropertyName("attributes")]
        public EntityAttributes Attributes { get; set; }

        [JsonPropertyName("ifcType")]
        public string IfcType { get; set; }
            
        [JsonPropertyName("objectId")]
        public long ObjectId { get; set; }

        [JsonPropertyName("ifcSchema")]
        public string IfcSchema { get; set; }

        //[JsonPropertyName("propertySets")]
        //public object[] PropertySets { get; set; }

        //[JsonPropertyName("quantitySets")]
        //public object[] QuantitySets { get; set; }

        //[JsonPropertyName("type")]
        //public object Type { get; set; }
    }
}
