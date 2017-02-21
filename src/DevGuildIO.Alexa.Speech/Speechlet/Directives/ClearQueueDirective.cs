using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Amazon.Speech.Speechlet.Directives
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#clearqueue-directive
    /// </summary>
    public class ClearQueueDirective : Directive
    {
        public override DirectiveType Type => DirectiveType.ClearQueue;

        /// <summary>
        /// Describes the clear queue behavior.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual ClearBehaviorEnum ClearBehavior { get; set; }

        /// <summary>
        /// Describes the clear queue behavior.
        /// </summary>
        public enum ClearBehaviorEnum
        {
            /// <summary>
            /// Clears the queue and continues to play the currently playing stream.
            /// </summary>
            [EnumMember(Value = "CLEAR_ENQUEUED")]
            ClearEnqueued,

            /// <summary>
            /// Clears the entire playback queue and stops the currently playing stream (if applicable).
            /// </summary>
            [EnumMember(Value = "CLEAR_ALL")]
            ClearAll
        }
    }
}
