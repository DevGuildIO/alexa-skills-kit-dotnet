
namespace DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#playbackstopped-request
    /// </summary>
    public class PlaybackStoppedRequest : AudioPlayerRequest
    {
        public override RequestType Type => RequestType.PlaybackStopped;

        /// <summary>
        /// Identifies a track’s offset in milliseconds when the PlaybackStopped request is sent.
        /// </summary>
        public virtual long OffsetInMilliseconds { get; set; }
    }
}
