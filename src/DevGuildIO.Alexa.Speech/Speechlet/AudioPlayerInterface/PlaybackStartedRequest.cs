
namespace DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#playbackstarted-request
    /// </summary>
    public class PlaybackStartedRequest : AudioPlayerRequest
    {
        public override RequestType Type => RequestType.PlaybackStarted;

        /// <summary>
        /// Identifies a track’s offset in milliseconds when the PlaybackStarted request is sent.
        /// </summary>
        public virtual long OffsetInMilliseconds { get; set; }
    }
}
