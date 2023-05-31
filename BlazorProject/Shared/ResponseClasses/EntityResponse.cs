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
        public Dictionary<string, IfcAttributeValue> Attributes { get; set; }
        //public EntityAttributes Attributes { get; set; }

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
    public class IfcAttributeValue
    {
        [JsonPropertyName("ifcType")]
        public string IfcType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
