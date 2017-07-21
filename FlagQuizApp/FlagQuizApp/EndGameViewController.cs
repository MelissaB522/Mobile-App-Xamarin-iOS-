using Foundation;
using System;
using UIKit;

namespace FlagQuizApp
{
    public partial class EndGameViewController : UIViewController
    {
        public EndGameViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Set label to number of correct answers
            lblCorrect.Text = "You got " + QuestionViewController.correct + " correct answers!";
        }

        partial void BtnPlayAgain_TouchUpInside(UIButton sender)
        {
            // Reset correct counter for new game
            QuestionViewController.correct = 0;
        }
    }
}