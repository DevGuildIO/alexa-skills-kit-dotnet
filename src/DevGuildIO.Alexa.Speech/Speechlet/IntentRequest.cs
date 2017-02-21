using DevGuildIO.Alexa.Speech.Slu;

namespace DevGuildIO.Alexa.Speech.Speechlet
{
    public class IntentRequest : SpeechletRequest
    {
        public override RequestType Type => RequestType.IntentRequest;

        public virtual Intent Intent { get; set; }
    }
}
