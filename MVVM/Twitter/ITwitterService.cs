using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MVVM.Twitter
{
    public interface ITwitterService
    {
        ObservableCollection<Tweet> GetNextTwentyTweetsFromUserId(string userId);
    }
}
