using System.Windows;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using MVVM.Twitter;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ITwitterViewModel _tvm;
        private WindsorContainer _container = new WindsorContainer();

        public MainWindow()
        {
            RegisterWindsorContainer();

            _tvm = new TwitterViewModel(_container.Resolve<ITwitterService>());
            _tvm.UpdateTweets("RealTimeWWII");

            DataContext = _tvm;

            InitializeComponent();
        }

        public void RegisterWindsorContainer()
        {
            _container.Register(
                Component.For<ITwitterService>().ImplementedBy<TwitterService>().LifeStyle.Singleton,
                Component.For<ITwitterViewModel>().ImplementedBy<TwitterViewModel>().LifeStyle.Transient);
        }
    }
}
