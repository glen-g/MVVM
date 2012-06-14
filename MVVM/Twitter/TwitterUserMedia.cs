using Newtonsoft.Json;

namespace MVVM.Twitter
{
    public class TwitterUserMedia
    {
        [JsonProperty("media_url")]
        public string media_url { get; set; }
    }
}