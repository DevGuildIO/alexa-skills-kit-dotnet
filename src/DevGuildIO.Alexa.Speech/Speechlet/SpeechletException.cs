using System;

namespace DevGuildIO.Alexa.Speech.Speechlet
{
    public class SpeechletException : Exception
    {
        public SpeechletException() : base()
        {
        }

        public SpeechletException(string message) : base(message)
        {
        }

        public SpeechletException(string message, Exception cause) : base(message, cause)
        {
        }
    }
}
