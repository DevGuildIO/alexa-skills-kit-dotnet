
namespace Amazon.Speech.Constants
{
    /// <summary>
    /// Built-in intents.
    /// Ref: https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/standard-intents
    /// </summary>
    public static class BuiltInIntents
    {
        /// <summary>
        /// Either of the following:
        /// - Let the user cancel a transaction or task(but remain in the skill)
        /// - Let the user completely exit the skill
        /// Phrases: cancel, never mind, forget it
        /// </summary>
        public const string Cancel = "AMAZON.CancelIntent";

        /// <summary>
        /// Provide help about how to use the skill. See “Offer Help for Complex Skills” in the Voice Design Best Practices for guidelines about help text.
        /// Phrases: help, help me, can you help me
        /// </summary>
        public const string Help = "AMAZON.HelpIntent";

        /// <summary>
        /// Lets the user request that the skill turn off a loop or repeat mode, usually for audio skills that stream a playlist of tracks.
        /// Phrases: loop off
        /// </summary>
        public const string LoopOff = "AMAZON.LoopOffIntent";

        /// <summary>
        /// Lets the user request that the skill turn on a loop or repeat mode, usually for audio skills that stream a playlist of tracks.
        /// Phrases: loop, loop on, keep repeating this song
        /// </summary>
        public const string LoopOn = "AMAZON.LoopOnIntent";

        /// <summary>
        /// Let the user navigate to the next item in a list.
        /// Phrases: next, skip, skip forward
        /// </summary>
        public const string Next = "AMAZON.NextIntent";
        
        /// <summary>
        /// Let the user provide a negative response to a yes/no question for confirmation.
        /// Phrases: no, no thanks
        /// </summary>
        public const string No = "AMAZON.NoIntent";

        /// <summary>
        /// Let the user pause an action in progress, such as pausing a game or pausing an audio track that is playing.
        /// Phrases: pause, pause that
        /// </summary>
        public const string Pause = "AMAZON.PauseIntent";

        /// <summary>
        /// Let the user go back to a previous item in a list.
        /// Phrases: go back, skip back, back up
        /// </summary>
        public const string Previous = "AMAZON.PreviousIntent";

        /// <summary>
        /// Let the user request to repeat the last action.
        /// Phrases: repeat, say that again, repeat that
        /// </summary>
        public const string Repeat = "AMAZON.RepeatIntent";

        /// <summary>
        /// Let the user resume or continue an action.
        /// Phrases: stop shuffling, shuffle off, turn off shuffle
        /// </summary>
        public const string Resume = "AMAZON.ResumeIntent";

        /// <summary>
        /// Lets the user request that the skill turn of a shuffle mode, usually for audio skills that stream a playlist of tracks.
        /// Phrases: stop shuffling, shuffle off, turn off shuffle
        /// </summary>
        public const string ShuffleOff = "AMAZON.ShuffleOffIntent";

        /// <summary>
        /// Lets the user request that the skill turn on a shuffle mode, usually for audio skills that stream a playlist of tracks.
        /// Phrases: shuffle, shuffle on, shuffle the music, shuffle mode
        /// </summary>
        public const string ShuffleOn = "AMAZON.ShuffleOnIntent";

        /// <summary>
        /// Let the user request to restart an action, such as restarting a game or a transaction.
        /// Phrases: start over, restart, start again
        /// </summary>
        public const string StartOver = "AMAZON.StartOverIntent";

        /// <summary>
        /// Either of the following:
        /// - Let the user stop an action(but remain in the skill)
        /// - Let the user completely exit the skill
        /// Phrases: stop, off, shut up
        /// </summary>
        public const string Stop = "AMAZON.StopIntent";

        /// <summary>
        /// Let the user provide a positive response to a yes/no question for confirmation.
        /// Phrases: yes, yes please, sure
        /// </summary>
        public const string Yes = "AMAZON.YesIntent";
    }
}
