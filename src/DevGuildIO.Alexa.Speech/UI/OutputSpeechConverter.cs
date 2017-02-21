using System;
using System.Reflection;
using System.Runtime.Serialization;
using DevGuildIO.Alexa.Speech.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DevGuildIO.Alexa.Speech.UI
{
    public class OutputSpeechConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;

            // get the request type property
            var request = JObject.Load(reader);
            var type = EnumSerializer.ToEnum<OutputSpeech.OutputType>(request.Value<string>("type"));

            // deserialize to the specified type
            switch (type)
            {
                case OutputSpeech.OutputType.PlainText:
                    return request.ToObject<PlainTextOutputSpeech>();
                case OutputSpeech.OutputType.SSML:
                    return request.ToObject<SsmlOutputSpeech>();
                default:
                    throw new SerializationException($"Output Speech type of \"{type}\" is invalid");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(OutputSpeech).IsAssignableFrom(objectType);
        }
    }
}
