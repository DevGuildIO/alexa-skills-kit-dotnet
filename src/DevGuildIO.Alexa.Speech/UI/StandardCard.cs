
namespace DevGuildIO.Alexa.Speech.UI
{
    public class StandardCard : Card
    {
        public override CardType Type => CardType.Standard;

        public virtual string Text { get; set; }

        public virtual Image Image { get; set; }
    }
}
