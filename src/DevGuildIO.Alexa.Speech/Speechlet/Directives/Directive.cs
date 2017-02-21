using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.Speech.Speechlet.Directives
{
    public abstract class Directive
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public abstract DirectiveType Type { get; }

        /// <summary>
        /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#audioplayer-directives
        /// </summary>
        public enum DirectiveType
        {
            /// <summary>
            /// Sends Alexa a command to stream the audio file identified by the specified audioItem.
            /// </summary>
            [EnumMember(Value = "AudioPlayer.Play")]
            Play,

            /// <summary>
            /// Stops any currently playing audio stream.
            /// </summary>
            [EnumMember(Value = "AudioPlayer.Stop")]
            Stop,

            /// <summary>
            /// Clears the queue of all audio streams.
            /// </summary>
            [EnumMember(Value = "AudioPlayer.ClearQueue")]
            ClearQueue
        }
    }
}
