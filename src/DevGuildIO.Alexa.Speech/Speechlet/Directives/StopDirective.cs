
namespace DevGuildIO.Alexa.Speech.Speechlet.Directives
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#stop-directive
    /// </summary>
    public class StopDirective : Directive
    {
        public override DirectiveType Type => DirectiveType.Stop;
    }
}
