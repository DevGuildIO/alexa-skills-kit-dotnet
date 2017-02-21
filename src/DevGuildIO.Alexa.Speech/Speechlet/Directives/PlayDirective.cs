using System.Runtime.Serialization;
using Amazon.Speech.Speechlet.AudioPlayerInterface;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.Speech.Speechlet.Directives
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#play-directive
    /// </summary>
    public class PlayDirective : Directive
    {
        public override DirectiveType Type => DirectiveType.Play;

        /// <summary>
        /// Describes playback behavior.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual PlaybackBehaviorType PlayBehavior { get; set; }

        /// <summary>
        /// Contains an object providing information about the audio stream to play.
        /// </summary>
        public virtual AudioItem AudioItem { get; set; }

        public enum PlaybackBehaviorType
        {
            /// <summary>
            /// Immediately begin playback of the specified stream, and replace current and enqueued streams.
            /// </summary>
            [EnumMember(Value = "REPLACE_ALL")]
            ReplaceAll,

            /// <summary>
            /// Add the specified stream to the end of the current queue. This does not impact the currently playing stream.
            /// </summary>
            [EnumMember(Value = "ENQUEUE")]
            Enqueue,

            /// <summary>
            /// Replace all streams in the queue. This does not impact the currently playing stream.
            /// </summary>
            [EnumMember(Value = "REPLACE_ENQUEUED")]
            ReplaceEnqueued
        }
    }
}
