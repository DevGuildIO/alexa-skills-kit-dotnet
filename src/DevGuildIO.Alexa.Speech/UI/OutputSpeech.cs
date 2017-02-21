
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevGuildIO.Alexa.Speech.UI
{
    public abstract class OutputSpeech
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public abstract OutputType Type { get; }

        public enum OutputType
        {
            PlainText,
            SSML
        }
    }
}
