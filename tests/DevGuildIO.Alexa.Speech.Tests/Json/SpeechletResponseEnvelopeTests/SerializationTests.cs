using System;
using System.IO;
using DevGuildIO.Alexa.Speech.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;

namespace DevGuildIO.Alexa.Speech.Tests.Json.SpeechletResponseEnvelopeTests
{
    [TestFixture]
    public class SerializationTests
    {
        [Test]
        public void Serialize_Response_Works()
        {
            // arrange
            var serializationSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            var path = Path.Combine(AppContext.BaseDirectory, "Assets\\SpeechletResponses\\FullResponse.json");
            var response = File.ReadAllText(path);

            // act
            var deserializedResponse = JsonConvert.DeserializeObject<SpeechletResponseEnvelope>(response);

            // assert
            Assert.IsNotNull(deserializedResponse);

            // act
            var serializedResponse = JsonConvert.SerializeObject(deserializedResponse, serializationSettings);

            // assert
            Assert.IsNotNull(serializedResponse);
            Assert.Greater(serializedResponse.Length, 0);
            // TODO: comparison of before/after json
        }
    }
}
