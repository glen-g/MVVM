using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MVVM.Twitter
{
    public interface ITwitterViewModel
    {
        ObservableCollection<Tweet> Tweets { get; }
        Tweet SelectedTweet { get; set; }
        string CurrentImageFromTweet { get; set; }
        void UpdateTweets(string userId);
    }
}
