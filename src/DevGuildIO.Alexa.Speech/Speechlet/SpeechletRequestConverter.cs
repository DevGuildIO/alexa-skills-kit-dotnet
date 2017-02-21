using System;
using System.Reflection;
using System.Runtime.Serialization;
using Amazon.Speech.Serialization;
using Amazon.Speech.Speechlet.AudioPlayerInterface;
using Amazon.Speech.Speechlet.PlaybackControllerInterface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Amazon.Speech.Speechlet
{
    public class SpeechletRequestConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // We allow serialization for debugging purposes but it shouldn't be needed
            // as we aren't mapping this object in the response
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;

            // get the request type property
            var request = JObject.Load(reader);
            var type = EnumSerializer.ToEnum<SpeechletRequest.RequestType>(request.Value<string>("type"));

            // convert it to an enum
            // deserialize to the specified type
            switch (type)
            {
                case SpeechletRequest.RequestType.LaunchRequest:
                    return request.ToObject<LaunchRequest>();
                case SpeechletRequest.RequestType.IntentRequest:
                    return request.ToObject<IntentRequest>();
                case SpeechletRequest.RequestType.SessionEndedRequest:
                    return request.ToObject<SessionEndedRequest>();
                case SpeechletRequest.RequestType.PlaybackStarted:
                    return request.ToObject<PlaybackStartedRequest>();
                case SpeechletRequest.RequestType.PlaybackFinished:
                    return request.ToObject<PlaybackFinishedRequest>();
                case SpeechletRequest.RequestType.PlaybackStopped:
                    return request.ToObject<PlaybackStoppedRequest>();
                case SpeechletRequest.RequestType.PlaybackNearlyFinished:
                    return request.ToObject<PlaybackNearlyFinishedRequest>();
                case SpeechletRequest.RequestType.PlaybackFailed:
                    return request.ToObject<PlaybackFailedRequest>();
                case SpeechletRequest.RequestType.NextCommandIssued:
                    return request.ToObject<NextCommandIssuedRequest>();
                case SpeechletRequest.RequestType.PauseCommandIssued:
                    return request.ToObject<PauseCommandIssuedRequest>();
                case SpeechletRequest.RequestType.PlayCommandIssued:
                    return request.ToObject<PlayCommandIssuedRequest>();
                case SpeechletRequest.RequestType.PreviousCommandIssued:
                    return request.ToObject<PreviousCommandIssuedRequest>();
                case SpeechletRequest.RequestType.SystemExceptionEncountered:
                    return request.ToObject<SystemExceptionEncounteredRequest>();
                default:
                    throw new SerializationException($"Request type of \"{type}\" is invalid");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(SpeechletRequest).IsAssignableFrom(objectType);
        }
    }
}
