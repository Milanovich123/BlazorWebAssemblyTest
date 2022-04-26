using System;
using System.Text.Json.Serialization;

namespace BlazorProject.Shared.ResponseClasses
{
    public partial class RevisionResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("version")]
        public long Version { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("model")]
        public ModelResponse Model { get; set; }

        [JsonPropertyName("user")]
        public UserResponse User { get; set; }
    }
}
