using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CheckNet;
using CheckNet.Android;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Graphics;
using CheckNet.CustomSwitch;
[assembly: ExportRenderer(typeof(CnSwitch), typeof(SwitchButtonRenderer))]
namespace CheckNet.Android
{
    class SwitchButtonRenderer : SwitchRenderer
    {
        //private CustomSwitch view;

        public SwitchButtonRenderer(Context context) : base(context)
        {       
        }
        
        protected override void OnElementChanged(ElementChangedEventArgs<Switch> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //SwitchThumbColor
                //Control.TrackDrawable.SetColorFilter(view.SwitchOnColor.ToAndroid(), PorterDuff.Mode.SrcAtop);
                //Control.TrackDrawable.SetColorFilter(global::Android.Graphics.Color.White);
                //this.Control.TrackDrawable.SetColorFilter(view.SwitchOnColor.ToAndroid(), PorterDuff.Mode.SrcAtop);

            }

        }
    }
}

