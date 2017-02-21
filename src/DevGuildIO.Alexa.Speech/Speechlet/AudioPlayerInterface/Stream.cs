
namespace Amazon.Speech.Speechlet.AudioPlayerInterface
{
    public class Stream
    {
        /// <summary>
        /// Identifies the location of audio content at a remote HTTPS location.
        /// 
        /// The supported formats for the audio file include AAC/MP4, MP3, HLS, PLS and M3U. Bitrates: 16kbps to 384 kbps.
        /// </summary>
        public virtual string Url { get; set; }

        /// <summary>
        /// An opaque token that represents the audio stream.This token cannot exceed 1024 characters.
        /// </summary>
        public virtual string Token { get; set; }

        /// <summary>
        /// An opaque token that represents the expected previous stream.
        /// 
        /// This property is required and allowed only when the playBehavior is ENQUEUE.This is used to prevent potential race conditions if requests to progress through a playlist and change tracks occur at the same time.
        /// </summary>
        public virtual string ExpectedPreviousToken { get; set; }

        /// <summary>
        /// The timestamp in the stream from which Alexa should begin playback. Set to 0 to start playing the stream from the beginning. Set to any other value to start playback from that associated point in the stream.
        /// </summary>
        public virtual long OffsetInMilliseconds { get; set; }
    }
}
