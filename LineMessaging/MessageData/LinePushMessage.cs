﻿using Newtonsoft.Json;
using System.Linq;

namespace LineMessaging
{
    public class LinePushMessage
    {
        public LinePushMessage()
        {
        }

        public LinePushMessage(string to, string message)
        {
            To = to;
            Messages = new[] { new LineTextMessage { Text = message } };
        }

        public LinePushMessage(string to, string[] message)
        {
            To = to;
            Messages = message.Select(x => new LineTextMessage { Text = x }).ToArray();
        }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("messages")]
        public LineMessageObjectBase[] Messages { get; set; }
    }
}
