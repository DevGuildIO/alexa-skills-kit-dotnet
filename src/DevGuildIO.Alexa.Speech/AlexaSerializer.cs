using System.IO;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Amazon.Speech
{
    public class AlexaSerializer : ILambdaSerializer
    {
        private readonly JsonSerializer _serializer;

        /// <summary>Constructs instance of serializer.</summary>
        public AlexaSerializer()
        {
            this._serializer = Newtonsoft.Json.JsonSerializer.Create(new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

        /// <summary>Serializes a particular object to a stream.</summary>
        /// <typeparam name="T">Type of object to serialize.</typeparam>
        /// <param name="response">Object to serialize.</param>
        /// <param name="responseStream">Output stream.</param>
        public void Serialize<T>(T response, Stream responseStream)
        {
            var streamWriter = new StreamWriter(responseStream);
            this._serializer.Serialize(streamWriter, response);
            streamWriter.Flush();
        }

        /// <summary>Deserializes a stream to a particular type.</summary>
        /// <typeparam name="T">Type of object to deserialize to.</typeparam>
        /// <param name="requestStream">Stream to serialize.</param>
        /// <returns>Deserialized object from stream.</returns>
        public T Deserialize<T>(Stream requestStream)
        {
            return this._serializer.Deserialize<T>(new JsonTextReader(new StreamReader(requestStream)));
        }
    }
}
