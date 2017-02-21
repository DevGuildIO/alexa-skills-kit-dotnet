
using DevGuildIO.Alexa.Speech.Speechlet;
using Newtonsoft.Json;

namespace DevGuildIO.Alexa.Speech.UI
{
    public class Reprompt
    {
        [JsonConverter(typeof(OutputSpeechConverter))]
        public virtual OutputSpeech OutputSpeech { get; set; }
    }
}
