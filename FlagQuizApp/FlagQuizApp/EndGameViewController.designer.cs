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
    [Register ("EndGameViewController")]
    partial class EndGameViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPlayAgain { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCorrect { get; set; }

        [Action ("BtnPlayAgain_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnPlayAgain_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnPlayAgain != null) {
                btnPlayAgain.Dispose ();
                btnPlayAgain = null;
            }

            if (lblCorrect != null) {
                lblCorrect.Dispose ();
                lblCorrect = null;
            }
        }
    }
}