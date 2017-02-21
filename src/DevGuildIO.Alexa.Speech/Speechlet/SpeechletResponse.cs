using System.Collections.Generic;
using Amazon.Speech.Speechlet.Directives;
using Amazon.Speech.UI;
using Newtonsoft.Json;

namespace Amazon.Speech.Speechlet
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/alexa-skills-kit-interface-reference#response-format
    /// </summary>
    public class SpeechletResponse
    {
        [JsonConverter(typeof(CardConverter))]
        public virtual Card Card { get; set; }

        [JsonConverter(typeof(OutputSpeechConverter))]
        public virtual OutputSpeech OutputSpeech { get; set; }

        public virtual Reprompt Reprompt { get; set; }
        
        [JsonConverter(typeof(DirectiveListConverter))]
        public virtual List<Directive> Directives { get; set; }

        public virtual bool ShouldEndSession { get; set; }
    }
}
