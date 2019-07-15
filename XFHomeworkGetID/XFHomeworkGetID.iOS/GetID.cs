using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace XFHomeworkGetID.iOS
{
    public class GetID : IGetID
    {
        public string GetdeviceID()
        {
            return UIKit.UIDevice.CurrentDevice.IdentifierForVendor.AsString();
        }
    }
}