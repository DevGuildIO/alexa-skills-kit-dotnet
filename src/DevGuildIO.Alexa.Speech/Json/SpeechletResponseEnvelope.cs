using System.Collections.Generic;
using Amazon.Speech.Speechlet;

namespace Amazon.Speech.Json
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/alexa-skills-kit-interface-reference#response-format
    /// </summary>
    public class SpeechletResponseEnvelope
    {
        public virtual SpeechletResponse Response { get; set; }

        public virtual Dictionary<string, string> SessionAttributes { get; set; }

        public virtual string Version { get; set; }
    }
}
