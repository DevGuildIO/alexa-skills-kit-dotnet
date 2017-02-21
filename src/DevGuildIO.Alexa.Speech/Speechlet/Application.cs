using Newtonsoft.Json;

namespace DevGuildIO.Alexa.Speech.Speechlet
{
    public class Application
    {
        [JsonProperty("applicationId")]
        public virtual string Id { get; set; }
    }
}
