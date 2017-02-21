using Amazon.Speech.Speechlet.AudioPlayerInterface;

namespace Amazon.Speech.Speechlet
{
    public class SystemExceptionEncounteredRequest : SpeechletRequest
    {
        public override RequestType Type => RequestType.SystemExceptionEncountered;

        public virtual MediaError Error { get; set; }

        public virtual Cause Cause { get; set; }
    }
}
