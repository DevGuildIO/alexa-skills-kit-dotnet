using Amazon.Speech.Slu;

namespace Amazon.Speech.Speechlet
{
    public class IntentRequest : SpeechletRequest
    {
        public override RequestType Type => RequestType.IntentRequest;

        public virtual Intent Intent { get; set; }
    }
}
