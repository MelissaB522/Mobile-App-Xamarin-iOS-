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

namespace FlagQuizApp
{
    [Register ("QuestionViewController")]
    partial class QuestionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn4 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgFlag { get; set; }

        [Action ("Btn1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Btn1_TouchUpInside (UIKit.UIButton sender);

        [Action ("Btn2_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Btn2_TouchUpInside (UIKit.UIButton sender);

        [Action ("Btn3_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Btn3_TouchUpInside (UIKit.UIButton sender);

        [Action ("Btn4_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Btn4_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btn1 != null) {
                btn1.Dispose ();
                btn1 = null;
            }

            if (btn2 != null) {
                btn2.Dispose ();
                btn2 = null;
            }

            if (btn3 != null) {
                btn3.Dispose ();
                btn3 = null;
            }

            if (btn4 != null) {
                btn4.Dispose ();
                btn4 = null;
            }

            if (imgFlag != null) {
                imgFlag.Dispose ();
                imgFlag = null;
            }
        }
    }
}