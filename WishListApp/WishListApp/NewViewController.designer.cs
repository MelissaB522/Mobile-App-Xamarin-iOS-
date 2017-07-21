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

namespace WishListApp
{
    [Register ("NewViewController")]
    partial class NewViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFetch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ivImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblItem { get; set; }

        [Action ("BtnFetch_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnFetch_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnFetch != null) {
                btnFetch.Dispose ();
                btnFetch = null;
            }

            if (ivImage != null) {
                ivImage.Dispose ();
                ivImage = null;
            }

            if (lblItem != null) {
                lblItem.Dispose ();
                lblItem = null;
            }
        }
    }
}