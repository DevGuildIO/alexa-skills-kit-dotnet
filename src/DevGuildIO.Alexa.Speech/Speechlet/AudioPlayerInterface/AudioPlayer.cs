using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface
{
    /// <summary>
    /// AudioPlayer is included on all customer-initiated requests (such as requests made by voice or using a remote control), 
    /// but includes the details about the playback (token and offsetInMilliseconds) only when sent to a skill that was most recently playing audio.
    /// 
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/alexa-skills-kit-interface-reference#audioplayer-object
    /// </summary>
    public class AudioPlayer
    {
        /// <summary>
        /// An opaque token that represents the audio stream described this AudioPlayer object. You provide this token when sending the Play directive. This is only included in the AudioPlayer object when your skill was the skill most recently playing audio on the device.
        /// </summary>
        public virtual string Token { get; set; }

        /// <summary>
        /// Identifies a track’s offset in milliseconds at the time the request was sent.This is 0 if the track is at the beginning.This is only included AudioPlayer object when your skill was the skill most recently playing audio on the device.
        /// </summary>
        public virtual long OffsetInMilliseconds { get; set; }

        /// <summary>
        /// Indicates the last known state of audio playback
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual PlayerActivityType PlayerActivity { get; set; }

        public enum PlayerActivityType
        {
            /// <summary>
            /// Nothing was playing, no enqueued items.
            /// </summary>
            [EnumMember(Value = "IDLE")]
            Idle,

            /// <summary>
            /// Stream was paused.
            /// </summary>
            [EnumMember(Value = "PAUSED")]
            Paused,

            /// <summary>
            /// Stream was playing.
            /// </summary>
            [EnumMember(Value = "PLAYING")]
            Playing,

            /// <summary>
            /// Buffer underrun.
            /// </summary>
            [EnumMember(Value = "BUFFER_UNDERRUN")]
            BufferUnderRun,

            /// <summary>
            /// Stream was finished playing.
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            Finished,

            /// <summary>
            /// Stream was interrupted.
            /// </summary>
            [EnumMember(Value = "STOPPED")]
            Stopped
        }
    }
}
