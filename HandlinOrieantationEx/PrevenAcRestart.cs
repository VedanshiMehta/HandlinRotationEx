using Android.App;
using Android.Content;
using Android.Content.Res;
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
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, ConfigurationChanges= Android.Content.PM.ConfigChanges.Orientation| Android.Content.PM.ConfigChanges.ScreenSize)]
    class PrevenAcRestart : Activity
    {
        TextView _mytv;
        RelativeLayout.LayoutParams _layoutPotraitParams;
        RelativeLayout.LayoutParams _layoutLandParams;

        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var rl = new RelativeLayout(this);
            var layoutParam = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.FillParent);
            var LayoutParams = layoutParam;

            var surfaceOrientation = WindowManager.DefaultDisplay.Rotation;

            _layoutPotraitParams= new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);
            _layoutLandParams = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);
            _layoutLandParams.TopMargin = 100;
            _layoutLandParams.LeftMargin = 100;

            _mytv = new TextView(this);

            if(surfaceOrientation == SurfaceOrientation.Rotation0 || surfaceOrientation == SurfaceOrientation.Rotation180)
            {

                _mytv.LayoutParameters = _layoutPotraitParams;
            }
            else
            {
                _mytv.LayoutParameters = _layoutLandParams;
            }

            _mytv.Text = "Programatic Layout";
            _mytv.TextSize = 24;

            rl.AddView(_mytv);
            SetContentView(rl);



        }

        public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            if (newConfig.Orientation == Android.Content.Res.Orientation.Portrait)
            {
                _mytv.LayoutParameters = _layoutPotraitParams;
                _mytv.Text = "Changed to Potrait";
            }
            else if (newConfig.Orientation == Android.Content.Res.Orientation.Landscape)
            {
                _mytv.LayoutParameters = _layoutLandParams;
                _mytv.Text = "Changed to Landscape";
            }
        }



    }
}