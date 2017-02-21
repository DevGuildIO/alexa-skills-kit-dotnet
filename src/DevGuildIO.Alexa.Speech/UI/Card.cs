using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevGuildIO.Alexa.Speech.UI
{
    public abstract class Card
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public abstract CardType Type { get; }

        public virtual string Title { get; set; }

        public enum CardType
        {
            Simple,
            Standard,
            LinkAccount
        }
    }
}
