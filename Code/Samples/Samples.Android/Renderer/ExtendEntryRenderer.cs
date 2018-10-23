using Android.Content;
using System;
using Android.App;
using Android.Views;
using Android.Graphics.Drawables;
using static Android.Resource;
using Android.Text;
using Android.Content.Res;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Samples.Controls.ExtendEntry), typeof(Samples.Droid.Renderer.ExtendEntryRenderer))]
namespace Samples.Droid.Renderer
{

    class ExtendEntryRenderer : Xamarin.Forms.Platform.Android.EntryRenderer
    {
        public ExtendEntryRenderer(Context context) : base(context)
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                #region  设置Entry无边框

                GradientDrawable gd = new GradientDrawable();
                gd.SetStroke(0, Android.Graphics.Color.Transparent);//边框宽度和边框颜色
                this.Control.SetBackgroundDrawable(gd);

                #endregion
            }
        }
    }
}