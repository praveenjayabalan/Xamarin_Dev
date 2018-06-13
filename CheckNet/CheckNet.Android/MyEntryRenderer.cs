using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CheckNet;
using CheckNet.Android;
using Android.Content;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace CheckNet.Android
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);

                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.White);
                gd.SetCornerRadius(15);
                
                gd.SetStroke(2, global::Android.Graphics.Color.Gray);
                
                Control.SetBackgroundDrawable(gd);



            }

        }
    }
}

