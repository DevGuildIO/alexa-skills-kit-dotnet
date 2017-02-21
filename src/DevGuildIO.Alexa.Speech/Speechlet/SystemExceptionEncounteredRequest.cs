using DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface;

namespace DevGuildIO.Alexa.Speech.Speechlet
{
    public class SystemExceptionEncounteredRequest : SpeechletRequest
    {
        public override RequestType Type => RequestType.SystemExceptionEncountered;

        public virtual MediaError Error { get; set; }

        public virtual Cause Cause { get; set; }
    }
}
