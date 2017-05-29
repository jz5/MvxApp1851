using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxApp1851.Core.ViewModels
{
    public class BarViewModel : MvxViewModelResult<string>
    {
        private readonly IMvxNavigationService NavigationService;
        public BarViewModel(IMvxNavigationService navigation)
        {
            NavigationService = navigation;
        }

        public MvxAsyncCommand CloseCommand => new MvxAsyncCommand(async () =>
        {
            await Close("result");
        });
    }
}
