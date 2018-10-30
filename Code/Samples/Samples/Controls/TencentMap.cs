using Samples.Directory.Senior.TencentMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samples.Controls
{
    public class TencentMap : Xamarin.Forms.ContentView
    {
        public IEnumerable<MapOption> Options;


        public TencentMap() {
            var options = new List<MapOption>()
            {
                new MapOption() { Title="成都职业技术学院",Lat=30.593860,Lng=104.061200},
                new MapOption() { Title="火车南站",Lat=30.605870,Lng=104.068610}
            };
            
            Options = options;
        }
    }
}
