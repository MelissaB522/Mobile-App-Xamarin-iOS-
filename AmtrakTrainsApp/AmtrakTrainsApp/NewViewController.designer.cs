// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AmtrakTrainsApp
{
    [Register ("NewViewController")]
    partial class NewViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgRedEye { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblRedEye { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtArrivalHour { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtArrivalMinute { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgRedEye != null) {
                imgRedEye.Dispose ();
                imgRedEye = null;
            }

            if (lblRedEye != null) {
                lblRedEye.Dispose ();
                lblRedEye = null;
            }

            if (txtArrivalHour != null) {
                txtArrivalHour.Dispose ();
                txtArrivalHour = null;
            }

            if (txtArrivalMinute != null) {
                txtArrivalMinute.Dispose ();
                txtArrivalMinute = null;
            }
        }
    }
}