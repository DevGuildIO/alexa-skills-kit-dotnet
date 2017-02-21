using System;
using System.Reflection;
using System.Runtime.Serialization;
using DevGuildIO.Alexa.Speech.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DevGuildIO.Alexa.Speech.UI
{
    public class CardConverter : JsonConverter
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
            var type = EnumSerializer.ToEnum<Card.CardType>(request.Value<string>("type"));

            // deserialize to the specified type
            switch (type)
            {
                case Card.CardType.Simple:
                    return request.ToObject<SimpleCard>();
                case Card.CardType.Standard:
                    return request.ToObject<StandardCard>();
                case Card.CardType.LinkAccount:
                    return request.ToObject<LinkAccountCard>();
                default:
                    throw new SerializationException($"Card type of \"{type}\" is invalid");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Card).IsAssignableFrom(objectType);
        }
    }
}
