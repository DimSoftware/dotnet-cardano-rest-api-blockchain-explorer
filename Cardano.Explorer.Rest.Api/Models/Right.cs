using System.Text.Json.Serialization;

namespace Cardano.Explorer.Rest.Api.Models
{
    public class Right<T>
    {
        [JsonPropertyName("Right")]
        public T Result { get; set; }
    }
}
