using DevGuildIO.Alexa.Speech.Speechlet.AudioPlayerInterface;

namespace DevGuildIO.Alexa.Speech.Speechlet
{
    /// <summary>
    /// https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/alexa-skills-kit-interface-reference#system-object
    /// </summary>
    public class System
    {
        /// <summary>
        /// An object containing an application ID.
        /// </summary>
        public virtual Application Application { get; set; }

        /// <summary>
        /// An object that describes the user making the request.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// An object providing information about the device used to send the request.
        /// </summary>
        public virtual Device Device { get; set; }
    }
}
