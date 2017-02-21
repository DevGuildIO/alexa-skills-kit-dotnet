
namespace Amazon.Speech.Speechlet.AudioPlayerInterface
{
    public abstract class AudioPlayerRequest : SpeechletRequest
    {
        /// <summary>
        /// An opaque token that represents the audio stream. You provide this token when sending the Play directive.
        /// </summary>
        public virtual string Token { get; set; }
    }
}
