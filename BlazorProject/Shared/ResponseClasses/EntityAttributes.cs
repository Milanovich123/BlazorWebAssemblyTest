using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorProject.Shared.ResponseClasses
{
    public class EntityAttributes
    {
        [JsonPropertyName("GlobalId")]
        public EntityAttributeValues GlobalId { get; set; }

        [JsonPropertyName("Name")]
        public EntityAttributeValues Name { get; set; }

        [JsonPropertyName("ObjectType")]
        public EntityAttributeValues ObjectType { get; set; }

        [JsonPropertyName("Tag")]
        public EntityAttributeValues Tag { get; set; }
    }

    public partial class EntityAttributeValues
    {
        [JsonPropertyName("ifcType")]
        public string IfcType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

}