
namespace DevGuildIO.Alexa.Speech.Speechlet.PlaybackControllerInterface
{
    /// <summary>
    /// Sent when the user uses a “pause” button with the intent to stop playback.
    /// 
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-playbackcontroller-interface-reference#pausecommandissued-request
    /// </summary>
    public class PauseCommandIssuedRequest : SpeechletRequest
    {
        public override RequestType Type => RequestType.PauseCommandIssued;
    }
}
