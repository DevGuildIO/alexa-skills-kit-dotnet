
namespace DevGuildIO.Alexa.Speech.Speechlet.PlaybackControllerInterface
{
    /// <summary>
    /// Sent when the user uses a “previous” button with the intent to go back to the previous audio item.
    /// 
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-playbackcontroller-interface-reference#previouscommandissued-request
    /// </summary>
    public class PreviousCommandIssuedRequest : SpeechletRequest
    {
        public override RequestType Type => RequestType.PreviousCommandIssued;
    }
}
