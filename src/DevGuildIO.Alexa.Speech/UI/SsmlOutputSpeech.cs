
namespace DevGuildIO.Alexa.Speech.UI
{
    public class SsmlOutputSpeech : OutputSpeech
    {
        public override OutputType Type => OutputType.SSML;

        public virtual string Ssml { get; set; }
    }
}
