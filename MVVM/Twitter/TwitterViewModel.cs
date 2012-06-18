using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using Newtonsoft.Json;

namespace MVVM.Twitter
{
    public class TwitterViewModel : INotifyPropertyChanged, ITwitterViewModel
    {
        private readonly ITwitterService _twitterService;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public readonly string _defaultCurrentImageFromTweet = "http://twitter.com/images/three_circles/twitter-bird-light-bgs.png";

        public ObservableCollection<Tweet> Tweets
        {
            get { return _tweets; }
        }

        public Tweet SelectedTweet
        {
            get { return _selectedTweet; }
            set
            {
                _selectedTweet = value;

                if (CheckIfTweetContainsEmbeddedImage(value))
                    CurrentImageFromTweet = value.entities.media.First().media_url;
                else
                    CurrentImageFromTweet = _defaultCurrentImageFromTweet;
            }
        }
        private Tweet _selectedTweet;

        public string CurrentTwitterId
        {
            get { return _currentTwitterUser; }
            set { _currentTwitterUser = value; }
        }

        private string _currentTwitterUser;

        public string CurrentImageFromTweet
        {
            get { return _currentImageFromTweet; }
            set
            {
                _currentImageFromTweet = value;
                RaisePropertyChanged("CurrentImageFromTweet");
            }
        }
        private string _currentImageFromTweet;

        private ObservableCollection<Tweet> _tweets = new ObservableCollection<Tweet>();
 
        public TwitterViewModel () : this(new TwitterService())
        {
            
        }

        public TwitterViewModel(ITwitterService twitterService)
        {
            _twitterService = twitterService;
        }

        public void UpdateTweets(string userId)
        {
            
            _tweets = _twitterService.GetNextTwentyTweetsFromUserId(userId);
            RaisePropertyChanged("Tweets");
        }

        private bool CheckIfTweetContainsEmbeddedImage(Tweet currentTweet)
        {
            if (currentTweet == null || currentTweet.entities == null || currentTweet.entities.media == null)
                return false;
            else
                return true;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
 
    }
}
