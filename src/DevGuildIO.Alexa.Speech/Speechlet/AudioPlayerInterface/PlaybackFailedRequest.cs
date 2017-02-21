
namespace DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#playbackfailed-request
    /// </summary>
    public class PlaybackFailedRequest : AudioPlayerRequest
    {
        public override RequestType Type => RequestType.PlaybackFailed;

        public virtual MediaError Error { get; set; }

        /// <summary>
        /// Contains an object providing details about the playback activity occurring at the time of the error.
        /// </summary>
        public virtual PlaybackState CurrentPlaybackState { get; set; }
    }
}
