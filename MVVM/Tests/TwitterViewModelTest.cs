using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using MVVM.Twitter;
using NUnit.Framework;
using Rhino.Mocks;

namespace MVVM.Tests
{
    [TestFixture]
    class TwitterViewModelTest
    {
        private ITwitterService _mock;
        private ITwitterViewModel _tvm;

        [SetUp]
        public void Init()
        {
            var tweets = new ObservableCollection<Tweet>()
                             {
                                 new Tweet
                                     {
                                         created_at = "1/1/2012",
                                         entities = new TwitterUserEntities
                                                        {
                                                            media = new List<TwitterUserMedia>()
                                                                        {
                                                                            new TwitterUserMedia
                                                                                {
                                                                                    media_url = "http://www.google.com/google.jpg"
                                                                                },
                                                                        },
                                                        },

                                         text = "Tweet from RealTimeWWII",
                                         user = new TwitterUser
                                                    {
                                                        screen_name = "RealTimeWWII",
                                                        name = "Real Tweets From WWII",
                                                        profile_image_url = "http://www.twitter.com/twitter.jpg"
                                                    },
                                     }
                             };

            _mock = MockRepository.GenerateMock<ITwitterService>();
            _mock.Stub(s => s.GetNextTwentyTweetsFromUserId("RealTimeWWII")).Return(tweets);

            _tvm = new TwitterViewModel(_mock);
            
        }

        [Test]
        public void UpdateTweetsShouldCallTwitterServiceToGetNextTwentyTweets()
        {
            _tvm.UpdateTweets("RealTimeWWII");

            _mock.AssertWasCalled(s => s.GetNextTwentyTweetsFromUserId("RealTimeWWII"));
        }

        [Test]
        public void TweetsGetUpdatedFromCallToUpdateTweets()
        {
            _tvm.UpdateTweets("RealTimeWWII");

            Assert.IsTrue(_tvm.Tweets.Count() == 1);
        }

        [Test]
        public void SelectedTweetShouldUpdateCurrentImageFromTweet()
        {
            _tvm.UpdateTweets("RealTimeWWII");

            _tvm.SelectedTweet = _tvm.Tweets.First();

            Assert.IsTrue(_tvm.CurrentImageFromTweet == "http://www.google.com/google.jpg");

        }
    }
}
