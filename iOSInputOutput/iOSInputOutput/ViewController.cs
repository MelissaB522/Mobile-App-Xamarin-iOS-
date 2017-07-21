using System;

using UIKit;
using TimesSquare.iOS;

namespace iOSInputOutput
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void DisplayButton_TouchUpInside(UIButton sender)
        {
            lblName.Text = txtName.Text;
            BirthdayLabel.Text = UserData.BirthDate.ToShortDateString();

        }
    }
}
