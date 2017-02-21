using System.Collections.Generic;
using DevGuildIO.Alexa.Speech.Speechlet;

namespace DevGuildIO.Alexa.Speech.Json
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
