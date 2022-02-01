using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandlinOrieantationEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class PrgHandelRotation : Activity
    {
        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var rl = new RelativeLayout(this);
            var layoutParams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.FillParent);
            var LayoutParameters = layoutParams;

            var surfaceOrientation = WindowManager.DefaultDisplay.Rotation;
            RelativeLayout.LayoutParams tvlayoutParams;

            if (surfaceOrientation == SurfaceOrientation.Rotation0 || surfaceOrientation == SurfaceOrientation.Rotation180)
            {
                tvlayoutParams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);
            }
            else
            {
                tvlayoutParams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);
                tvlayoutParams.LeftMargin = 100;
                tvlayoutParams.TopMargin = 100;
            }
            var tv = new TextView(this);
            tv.LayoutParameters = layoutParams;
            tv.Text = "Programmatic Layout";

            rl.AddView(tv);
            SetContentView(rl);
        }
    }
}