
namespace DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#playbacknearlyfinished-request
    /// </summary>
    public class PlaybackNearlyFinishedRequest : AudioPlayerRequest
    {
        public override RequestType Type => RequestType.PlaybackNearlyFinished;

        /// <summary>
        /// Identifies a track’s offset in milliseconds when the PlaybackNearlyFinished request is sent.
        /// </summary>
        public virtual long OffsetInMilliseconds { get; set; }
    }
}
