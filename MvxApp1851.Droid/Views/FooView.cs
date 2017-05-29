using Android.App;
using Android.OS;

namespace MvxApp1851.Droid.Views
{
    [Activity(Label = "View for FooViewModel")]
    public class FooView : BaseView
    {
        protected override int LayoutResource => Resource.Layout.FooView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}
