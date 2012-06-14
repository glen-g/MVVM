using Newtonsoft.Json;

namespace MVVM.Twitter
{
    public class TwitterUser
    {
        [JsonProperty("screen_name")]
        public string screen_name { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("profile_image_url")]
        public string profile_image_url { get; set; }

    }
}