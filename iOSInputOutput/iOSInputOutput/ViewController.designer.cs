// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace iOSInputOutput
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BirthdayLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CalendarButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DisplayButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtName { get; set; }

        [Action ("DisplayButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DisplayButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BirthdayLabel != null) {
                BirthdayLabel.Dispose ();
                BirthdayLabel = null;
            }

            if (CalendarButton != null) {
                CalendarButton.Dispose ();
                CalendarButton = null;
            }

            if (DisplayButton != null) {
                DisplayButton.Dispose ();
                DisplayButton = null;
            }

            if (lblName != null) {
                lblName.Dispose ();
                lblName = null;
            }

            if (txtName != null) {
                txtName.Dispose ();
                txtName = null;
            }
        }
    }
}