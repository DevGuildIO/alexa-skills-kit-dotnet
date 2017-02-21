using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevGuildIO.Alexa.Speech.Speechlet
{
    public abstract class SpeechletRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public abstract RequestType Type { get; }

        public virtual string RequestId { get; set; }

        public virtual string Locale { get; set; }

        public virtual DateTime Timestamp { get; set; }

        public enum RequestType
        {
            LaunchRequest,
            IntentRequest,
            SessionEndedRequest,

            /// <summary>
            /// Sent when Alexa begins playing the audio stream previously sent in a Play directive. This lets your skill verify that playback began successfully.
            /// </summary>
            [EnumMember(Value = "AudioPlayer.PlaybackStarted")]
            PlaybackStarted,

            /// <summary>
            /// Sent when the stream Alexa is playing comes to an end on its own.
            /// </summary>
            [EnumMember(Value = "AudioPlayer.PlaybackFinished")]
            PlaybackFinished,

            /// <summary>
            /// Sent when Alexa stops playing an audio stream in response to a voice request or an AudioPlayer directive.
            /// </summary>
            [EnumMember(Value = "AudioPlayer.PlaybackStopped")]
            PlaybackStopped,

            /// <summary>
            /// Sent when the currently playing stream is nearly complete and the device is ready to receive a new stream.
            /// </summary>
            [EnumMember(Value = "AudioPlayer.PlaybackNearlyFinished")]
            PlaybackNearlyFinished,

            /// <summary>
            /// Sent when Alexa encounters an error when attempting to play a stream.
            /// </summary>
            [EnumMember(Value = "AudioPlayer.PlaybackFailed")]
            PlaybackFailed,

            /// <summary>
            /// Sent when the user uses a “next” button with the intent to skip to the next audio item.
            /// </summary>
            [EnumMember(Value = "PlaybackController.NextCommandIssued")]
            NextCommandIssued,

            /// <summary>
            /// Sent when the user uses a “pause” button with the intent to stop playback.
            /// </summary>
            [EnumMember(Value = "PlaybackController.PauseCommandIssued")]
            PauseCommandIssued,

            /// <summary>
            /// Sent when the user uses a “play” or “resume” button with the intent to start or resume playback.
            /// </summary>
            [EnumMember(Value = "PlaybackController.PlayCommandIssued")]
            PlayCommandIssued,

            /// <summary>
            /// Sent when the user uses a “previous” button with the intent to go back to the previous audio item.
            /// </summary>
            [EnumMember(Value = "PlaybackController.PreviousCommandIssued")]
            PreviousCommandIssued,

            /// <summary>
            /// If a response to an AudioPlayer request causes an error, your skill is sent a System.ExceptionEncountered request. Any directives included in the response are ignored.
            /// </summary>
            [EnumMember(Value = "System.ExceptionEncountered")]
            SystemExceptionEncountered
        }
    }
}
