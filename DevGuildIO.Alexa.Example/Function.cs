using Amazon.Lambda.Core;
using DevGuildIO.Alexa.Speech;
using DevGuildIO.Alexa.Speech.Json;
using DevGuildIO.Alexa.Speech.Speechlet;
using DevGuildIO.Alexa.Speech.UI;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(AlexaSerializer))]

namespace DevGuildIO.Alexa.Example
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public SpeechletResponseEnvelope FunctionHandler(SpeechletRequestEnvelope input, ILambdaContext context)
        {
            context.Logger.Log(JsonConvert.SerializeObject(input));

            return new SpeechletResponseEnvelope
            {
                Response = new SpeechletResponse
                {
                    OutputSpeech = new PlainTextOutputSpeech
                    {
                        Text = ((IntentRequest)input.Request).Intent.Slots["Word"].Value
                    }
                }
            };
        }
    }
}
