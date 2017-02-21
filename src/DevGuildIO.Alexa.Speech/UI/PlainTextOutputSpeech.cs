
namespace DevGuildIO.Alexa.Speech.UI
{
    public class PlainTextOutputSpeech : OutputSpeech
    {
        public override OutputType Type => OutputType.PlainText;

        public virtual string Text { get; set; }
    }
}
