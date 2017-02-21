
namespace Amazon.Speech.Speechlet.PlaybackControllerInterface
{
    /// <summary>
    /// Sent when the user uses a “play” or “resume” button with the intent to start or resume playback.
    /// 
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-playbackcontroller-interface-reference#playcommandissued-request
    /// </summary>
    public class PlayCommandIssuedRequest : SpeechletRequest
    {
        public override RequestType Type => RequestType.PlayCommandIssued;
    }
}
