using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace MVVM.Twitter
{
    public class TwitterService : ITwitterService
    {
        public ObservableCollection<Tweet> GetNextTwentyTweetsFromUserId(string userId)
        {
            var client = new WebClient();
            var json = client.DownloadString(new Uri("https://api.twitter.com/1/statuses/user_timeline.json?screen_name=" + userId + "&include_entities=1&count=20"));

            var tweets = JsonConvert.DeserializeObject<ObservableCollection<Tweet>>(json);

            return tweets;  
        }

    }

}
