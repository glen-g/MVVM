using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MVVM.Twitter;
using NUnit.Framework;

namespace MVVM.Tests
{
    [TestFixture]
    class TwitterTest
    {
        [Test]
        public void ShouldGetNextTwentyTweetsFromUserId()
        {
            ITwitterViewModel tv = new Twitter.TwitterViewModel();
            tv.UpdateTweets("RealTimeWWII");

            Assert.IsTrue(tv.Tweets.Count == 20);
        }
        
    }
}
