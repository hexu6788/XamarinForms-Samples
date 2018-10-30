using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Amap.Api.Maps2d;
using Samples.Directory.Senior.TencentMap;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Samples.Controls.GaodeMap), typeof(Samples.Droid.Renderer.GaodeMapRenderer))]
namespace Samples.Droid.Renderer
{
    public class GaodeMapRenderer : ViewRenderer
    {
        /// <summary>
        /// 腾讯地图视图
        /// </summary>
        private MapView mapView;

        

        /// <summary>
        /// 布局
        /// </summary>
        private LinearLayout layout;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null || e.OldElement != null)
            {
                return;
            }

            //e.NewElement就是承载的界面，这里就是PCL项目里面的MainPage
            //var mainPage = e.NewElement as TencentMapSamples;
            var mainPage = e.NewElement as Samples.Controls.GaodeMap;

            //初始化mapView
            mapView = new MapView(this.Context);
            mapView.OnCreate(null);

            //初始化视图
            layout = new LinearLayout(this.Context);
            layout.AddView(mapView);
            this.AddView(layout);

            //这里可以比对以下我们的写法跟腾讯官网里Java写法的区别，可以看出Java里面的属性是set,get前缀，而在C#里面都被隐藏了，直接用C#惯用的属性写法来代替，而方法则还是同样的SetXXX(),GetXXX()，但是Java是camelCasing，C#用PascalCasing写法（博主非常喜欢C#写法，而很讨厌Java的写法 :-)）。这些区别，都是Xamarin 里 绑定Java库的转换规则。 

            #region TencentMap类
            //腾讯地图的设置是通过TencentMap类进行设置，可以控制地图的底图类型、显示范围、缩放级别、添加 / 删除marker和图形，此外对于地图的各种回调监听也是绑定到TencentMap。下面是TencentMap类的使用示例：

            //获取TencentMap实例
            var gaodeMap = mapView.Map;
            //设置实时路况开启
            gaodeMap.TrafficEnabled = true;
            //设置地图中心点
            //gaodeMap.SetCenter(new Com.Tencent.Mapsdk.Raster.Model.LatLng(30.605870, 104.068610));
            //设置缩放级别
            //gaodeMap.SetZoom(11);
            #endregion

            #region UiSettings类
            //UiSettings类用于设置地图的视图状态，如Logo位置设置、比例尺位置设置、地图手势开关等。下面是UiSettings类的使用示例：

            //获取UiSettings实例
            //UiSettings uiSettings = mapView.UiSettings;
            //设置logo到屏幕底部中心
            //uiSettings.SetLogoPosition(UiSettings.LogoPositionCenterBottom);
            //设置比例尺到屏幕右下角
            //uiSettings.SetScaleViewPosition(UiSettings.ScaleviewPositionRightBottom);
            //启用缩放手势(更多的手势控制请参考开发手册)
            //uiSettings.SetZoomGesturesEnabled(true);
            #endregion

            #region 使用marker
            //注意，这里要往resources/drawable/里添加一个red_location.png的图片
            //var bitmap = Resources.GetBitmap("red_location.png");
            //BitmapDescriptor des = new BitmapDescriptor(bitmap);
            //foreach (var item in mainPage.Options)
            //{
            //    MarkerOptions options = new MarkerOptions();

            //    options.InvokeIcon(des);
            //    options.InvokeTitle(item.Title);
            //    options.Anchor(0.5f, 0.5f);
            //    options.InvokePosition(new LatLng(item.Lat, item.Lng));
            //    options.Draggable(true);
            //    Marker marker = mapView.AddMarker(options);
            //    marker.ShowInfoWindow();
            //}

            #endregion

        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            var msw = Android.Views.View.MeasureSpec.MakeMeasureSpec(r - l, MeasureSpecMode.Exactly);
            var msh = Android.Views.View.MeasureSpec.MakeMeasureSpec(b - t, MeasureSpecMode.Exactly);
            layout.Measure(msw, msh);
            layout.Layout(0, 0, r - l, b - t);
        }
    }
}