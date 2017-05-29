using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxApp1851.Core.ViewModels
{
    public class FooViewModel : MvxViewModelResult<string>
    {
        private readonly IMvxNavigationService NavigationService;
        public FooViewModel(IMvxNavigationService navigation)
        {
            NavigationService = navigation;
        }

        public MvxAsyncCommand BarCommand => new MvxAsyncCommand(async () =>
        {
            var result = await NavigationService.Navigate<BarViewModel, string>();
            await Close(result);
        });
    }
}
