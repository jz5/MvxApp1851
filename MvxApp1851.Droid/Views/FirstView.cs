using Android.App;
using Android.OS;

namespace MvxApp1851.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : BaseView
    {
        protected override int LayoutResource => Resource.Layout.FirstView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}
