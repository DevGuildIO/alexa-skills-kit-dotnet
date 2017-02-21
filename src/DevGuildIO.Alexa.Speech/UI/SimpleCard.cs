
namespace DevGuildIO.Alexa.Speech.UI
{
    public class SimpleCard : Card
    {
        public override CardType Type => CardType.Simple;

        public virtual string Content { get; set; }
    }
}
