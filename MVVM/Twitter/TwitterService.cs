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
            ObservableCollection<Tweet> tweets;

            var client = new WebClient();


            try
            {
                var json = client.DownloadString(
                    new Uri("https://api.twitter.com/1/statuses/user_timeline.json?screen_name=" + userId +
                            "&include_entities=1&count=20"));

                tweets = JsonConvert.DeserializeObject<ObservableCollection<Tweet>>(json);
            }
            catch (WebException e)
            {
                tweets = new ObservableCollection<Tweet>
                             {
                                 new Tweet
                                     {
                                         text = "Invalid TwitterID.",
                                     }
                             };
            }

            return tweets;
        }

    }

}
