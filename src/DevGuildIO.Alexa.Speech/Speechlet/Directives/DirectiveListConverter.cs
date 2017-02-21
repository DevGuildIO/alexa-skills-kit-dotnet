using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using DevGuildIO.Alexa.Speech.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DevGuildIO.Alexa.Speech.Speechlet.Directives
{
    public class DirectiveListConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var list = (IList) Activator.CreateInstance(objectType);
            
            var request = JArray.Load(reader);

            foreach (var obj in request)
            {
                list.Add(SerializeDirective(obj));
            }

            return list;
        }

        private object SerializeDirective(JToken obj)
        {
            var type = EnumSerializer.ToEnum<Directive.DirectiveType>(obj.Value<string>("type"));

            // deserialize to the specified type
            switch (type)
            {
                case Directive.DirectiveType.Play:
                    return obj.ToObject<PlayDirective>();
                case Directive.DirectiveType.Stop:
                    return obj.ToObject<StopDirective>();
                case Directive.DirectiveType.ClearQueue:
                    return obj.ToObject<ClearQueueDirective>();
                default:
                    throw new SerializationException($"Directive type of \"{type}\" is invalid");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IList<Directive>).IsAssignableFrom(objectType);
        }
    }
}
