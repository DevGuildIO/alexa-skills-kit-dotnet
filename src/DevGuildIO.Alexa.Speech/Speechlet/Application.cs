using Newtonsoft.Json;

namespace Amazon.Speech.Speechlet
{
    public class Application
    {
        [JsonProperty("applicationId")]
        public virtual string Id { get; set; }
    }
}
