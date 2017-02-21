
namespace DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface
{
    public class PlaybackState
    {
        /// <summary>
        /// An opaque token that represents the audio stream currently playing when the error occurred. Note that this may be different from the value of the request.token property.
        /// </summary>
        public virtual string Token { get; set; }

        /// <summary>
        /// Identifies a track’s offset in milliseconds when the error occurred.
        /// </summary>
        public virtual long OffsetInMilliseconds { get; set; }

        /// <summary>
        /// Identifies the player state when the error occurred: PLAYING, PAUSED, FINISHED, BUFFER_UNDERRUN, or IDLE.
        /// </summary>
        public virtual string PlayerActivity { get; set; }
    }
}
