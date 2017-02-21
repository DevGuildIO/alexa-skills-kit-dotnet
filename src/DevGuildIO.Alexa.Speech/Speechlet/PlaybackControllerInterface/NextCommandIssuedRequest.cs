
namespace DevGuildIO.Alexa.Speech.Speechlet.PlaybackControllerInterface
{
    /// <summary>
    /// Sent when the user uses a “next” button with the intent to skip to the next audio item.
    /// 
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-playbackcontroller-interface-reference#nextcommandissued-request
    /// </summary>
    public class NextCommandIssuedRequest : SpeechletRequest
    {
        public override RequestType Type => RequestType.NextCommandIssued;
    }
}
