
namespace DevGuildIO.Alexa.Speech.Speechlet
{
    /// <summary>
    /// The context object provides your skill with information about the current state of the Alexa service 
    /// and device at the time the request is sent to your service. This is included on all requests.
    ///  For requests sent in the context of a session (LaunchRequest and IntentRequest), the context object 
    /// duplicates the user and application information that is also available in the session.
    /// 
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/alexa-skills-kit-interface-reference#context-object
    /// </summary>
    public class Context
    {
        public virtual System System { get; set; }
    }
}
