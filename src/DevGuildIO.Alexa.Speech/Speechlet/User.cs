using Newtonsoft.Json;

namespace DevGuildIO.Alexa.Speech.Speechlet
{
    public class User
    {
        [JsonProperty("userId")]
        public virtual string Id { get; set; }
        
        public virtual string AccessToken { get; set; }
    }
}
