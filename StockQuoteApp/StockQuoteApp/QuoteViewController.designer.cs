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

namespace StockQuoteApp
{
    [Register ("QuoteViewController")]
    partial class QuoteViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblChange { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHigh { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLow { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblValue { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblChange != null) {
                lblChange.Dispose ();
                lblChange = null;
            }

            if (lblHigh != null) {
                lblHigh.Dispose ();
                lblHigh = null;
            }

            if (lblLow != null) {
                lblLow.Dispose ();
                lblLow = null;
            }

            if (lblName != null) {
                lblName.Dispose ();
                lblName = null;
            }

            if (lblValue != null) {
                lblValue.Dispose ();
                lblValue = null;
            }
        }
    }
}