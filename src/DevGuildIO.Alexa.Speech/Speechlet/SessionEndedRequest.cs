using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevGuildIO.Alexa.Speech.Speechlet
{
    public class SessionEndedRequest : SpeechletRequest
    {
        public override RequestType Type => RequestType.SessionEndedRequest;

        [JsonConverter(typeof(StringEnumConverter))]
        public virtual ReasonEnum Reason { get; set; }

        public enum ReasonEnum
        {
            [EnumMember(Value = "NONE")]
            None = 0,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "USER_INITIATED")]
            UserInitiated,
            [EnumMember(Value = "EXCEEDED_MAX_REPROMPTS")]
            ExceededMaxReprompts,
        }
    }
}
