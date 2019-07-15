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

namespace XFHomeworkGetID.Droid
{
    public class GetID : IGetID
    {
        public string GetdeviceID()
        {
            return Android.OS.Build.Serial;
        }
    }
}