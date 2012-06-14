using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MVVM.Twitter
{
    public class Tweet
    {
        [JsonProperty("created_at")]
        public string created_at { get; set; }

        [JsonProperty("text")]
        public string text { get; set; }

        [JsonProperty("user")]
        public TwitterUser user { get; set; }

        [JsonProperty("entities")]
        public TwitterUserEntities entities { get; set; }
    }
}
