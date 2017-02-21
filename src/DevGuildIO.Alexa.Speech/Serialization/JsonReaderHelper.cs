﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Amazon.Speech.Serialization
{
    public static class JsonReaderHelper
    {
        /// <summary>
        /// Creates a new reader for the specified jObject by copying the settings
        /// from an existing reader.
        /// </summary>
        /// <param name="reader">The reader whose settings should be copied.</param>
        /// <param name="jToken">The JToken to create a new reader for.</param>
        /// <returns>The new disposable reader.</returns>
        public static JsonReader CopyReaderForObject(JsonReader reader, JToken jToken)
        {
            var jObjectReader = jToken.CreateReader();
            jObjectReader.Culture = reader.Culture;
            jObjectReader.DateFormatString = reader.DateFormatString;
            jObjectReader.DateParseHandling = reader.DateParseHandling;
            jObjectReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
            jObjectReader.FloatParseHandling = reader.FloatParseHandling;
            jObjectReader.MaxDepth = reader.MaxDepth;
            jObjectReader.SupportMultipleContent = reader.SupportMultipleContent;
            return jObjectReader;
        }
    }
}
