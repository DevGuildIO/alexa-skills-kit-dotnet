
using Amazon.Speech.Speechlet;
using Newtonsoft.Json;

namespace Amazon.Speech.UI
{
    public class Reprompt
    {
        [JsonConverter(typeof(OutputSpeechConverter))]
        public virtual OutputSpeech OutputSpeech { get; set; }
    }
}
