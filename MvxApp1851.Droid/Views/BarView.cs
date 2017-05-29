using Android.App;
using Android.OS;

namespace MvxApp1851.Droid.Views
{
    [Activity(Label = "View for BarViewModel")]
    public class BarView : BaseView
    {
        protected override int LayoutResource => Resource.Layout.BarView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}
