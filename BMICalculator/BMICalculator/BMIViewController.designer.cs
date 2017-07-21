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

namespace BMICalculator
{
    [Register ("BMIViewController")]
    partial class BMIViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblBMI { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblBMI != null) {
                lblBMI.Dispose ();
                lblBMI = null;
            }
        }
    }
}