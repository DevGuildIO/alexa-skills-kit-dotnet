using System;
using System.IO;
using DevGuildIO.Alexa.Speech.Json;
using DevGuildIO.Alexa.Speech.Speechlet;
using Newtonsoft.Json;
using NUnit.Framework;

namespace DevGuildIO.Alexa.Speech.Tests.Json.SpeechletRequestEnvelopeTests
{
    [TestFixture]
    public class DeserializationTests
    {
        [Test]
        public void Deserialize_LaunchRequest_Works()
        {
            // arrange
            var path = Path.Combine(AppContext.BaseDirectory, "Assets\\SpeechletRequests\\SpeechletLaunchRequest.json");
            var request = File.ReadAllText(path);

            // act
            var deserializedRequest = JsonConvert.DeserializeObject<SpeechletRequestEnvelope>(request);

            // assert
            Assert.IsNotNull(deserializedRequest);
            Assert.IsInstanceOf<LaunchRequest>(deserializedRequest.Request);
        }

        [Test]
        public void Deserialize_IntentRequest_Works()
        {
            // arrange
            var path = Path.Combine(AppContext.BaseDirectory, "Assets\\SpeechletRequests\\SpeechletIntentRequest.json");
            var request = File.ReadAllText(path);

            // act
            var deserializedRequest = JsonConvert.DeserializeObject<SpeechletRequestEnvelope>(request);

            // assert
            Assert.IsNotNull(deserializedRequest);
            Assert.IsInstanceOf<IntentRequest>(deserializedRequest.Request);
        }

        [Test]
        public void Deserialize_EndSession_Works()
        {
            // arrange
            var path = Path.Combine(AppContext.BaseDirectory, "Assets\\SpeechletRequests\\SpeechletEndSessionRequest.json");
            var request = File.ReadAllText(path);

            // act
            var deserializedRequest = JsonConvert.DeserializeObject<SpeechletRequestEnvelope>(request);

            // assert
            Assert.IsNotNull(deserializedRequest);
            Assert.IsInstanceOf<SessionEndedRequest>(deserializedRequest.Request);
        }
    }
}
