using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface
{
    public class MediaError
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual MediaErrorType Type { get; set; }

        public virtual string Message { get; set; }

        public enum MediaErrorType
        {
            /// <summary>
            /// An unknown error occurred.
            /// </summary>
            [EnumMember(Value = "MEDIA_ERROR_UNKNOWN")]
            Unknown,

            /// <summary>
            /// Alexa recognized the request as being malformed. E.g. bad request, unauthorized, forbidden, not found, etc.
            /// </summary>
            [EnumMember(Value = "MEDIA_ERROR_INVALID_REQUEST")]
            InvalidRequest,

            /// <summary>
            /// Alexa was unable to reach the URL for the stream.
            /// </summary>
            [EnumMember(Value = "MEDIA_ERROR_SERVICE_UNAVAILABLE")]
            ServiceUnavailable,

            /// <summary>
            /// Alexa accepted the request, but was unable to process the request as expected.
            /// </summary>
            [EnumMember(Value = "MEDIA_ERROR_INTERNAL_SERVER_ERROR")]
            ServerError,

            /// <summary>
            /// There was an internal error on the device.
            /// </summary>
            [EnumMember(Value = "MEDIA_ERROR_INTERNAL_DEVICE_ERROR")]
            InternalDeviceError
        }
    }
}
