
namespace DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#playbackfinished-request
    /// </summary>
    public class PlaybackFinishedRequest : AudioPlayerRequest
    {
        public override RequestType Type => RequestType.PlaybackFinished;

        /// <summary>
        /// Identifies a track’s offset in milliseconds when the PlaybackFinished request is sent.
        /// </summary>
        public virtual long OffsetInMilliseconds { get; set; }
    }
}
