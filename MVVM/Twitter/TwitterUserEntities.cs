using System.Collections.Generic;
using Newtonsoft.Json;

namespace MVVM.Twitter
{
    public class TwitterUserEntities
    {
        [JsonProperty("media")]
        public List<TwitterUserMedia> media { get; set; }
    }
}