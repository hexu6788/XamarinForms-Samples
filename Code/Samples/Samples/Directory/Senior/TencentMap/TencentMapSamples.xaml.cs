using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Directory.Senior.TencentMap
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TencentMapSamples : ContentPage
    {
        public IEnumerable<MapOption> Options;

        public TencentMapSamples()
        {
            InitializeComponent();
        }
    }

    /// <summary>
    /// 标记类
    /// </summary>
    public class MapOption
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public double Lng { get; set; }
    }
}