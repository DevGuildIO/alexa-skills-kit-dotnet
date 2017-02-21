using System;
using System.Collections.Generic;

namespace DevGuildIO.Alexa.Speech.Slu
{
    public class Intent
    {
        public virtual string Name { get; set; }

        public virtual Dictionary<string, Slot> Slots
        {
            get
            {
                return _slots;
            }
            set
            {
                // slot names are case insensitive
                _slots = new Dictionary<string, Slot>(value, StringComparer.OrdinalIgnoreCase);
            }
        }

        private Dictionary<string, Slot> _slots;
    }
}
