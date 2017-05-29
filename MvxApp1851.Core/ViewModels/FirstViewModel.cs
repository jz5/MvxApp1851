using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxApp1851.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        private readonly IMvxNavigationService NavigationService;
        public FirstViewModel(IMvxNavigationService navigation)
        {
            NavigationService = navigation;
        }

        public MvxAsyncCommand FooCommand => new MvxAsyncCommand(async () =>
        {
            var result = await NavigationService.Navigate<FooViewModel, string>();
            Hello = result;
        });

        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }
    }
}
