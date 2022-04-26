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
        public ObjectTypeClass GlobalId { get; set; }

        [JsonPropertyName("Name")]
        public ObjectTypeClass Name { get; set; }

        [JsonPropertyName("ObjectType")]
        public ObjectTypeClass ObjectType { get; set; }

        [JsonPropertyName("Tag")]
        public ObjectTypeClass Tag { get; set; }
    }

    public partial class ObjectTypeClass
    {
        [JsonPropertyName("ifcType")]
        public string IfcType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

}