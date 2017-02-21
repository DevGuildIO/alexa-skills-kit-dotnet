
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amazon.Speech.Speechlet
{
    public class Session
    {
        public virtual string SessionId { get; set; }

        [JsonProperty("new")]
        public virtual bool IsNew { get; set; }

        public virtual Application Application { get; set; }

        public virtual User User { get; set; }

        [JsonProperty("sessionAttributes")]
        public virtual Dictionary<string, string> Attributes { get; set; }
    }
}
