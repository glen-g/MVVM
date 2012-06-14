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
                    CurrentImageFromTweet = "";
            }
        }
        private Tweet _selectedTweet;

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
        }

        private bool CheckIfTweetContainsEmbeddedImage(Tweet currentTweet)
        {
            if (currentTweet.entities.media == null)
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
