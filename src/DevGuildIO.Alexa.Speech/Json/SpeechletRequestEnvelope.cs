using Amazon.Speech.Speechlet;
using Newtonsoft.Json;

namespace Amazon.Speech.Json
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/alexa-skills-kit-interface-reference#request-format
    /// </summary>
    public class SpeechletRequestEnvelope
    {
        [JsonConverter(typeof(SpeechletRequestConverter))]
        public virtual SpeechletRequest Request { get; set; }

        public virtual Session Session { get; set; }

        public virtual Context Context { get; set; }

        public virtual string Version { get; set; }
    }
}
