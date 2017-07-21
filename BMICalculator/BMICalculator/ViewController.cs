using System;

using UIKit;

namespace BMICalculator
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

        partial void BtnCalc_TouchUpInside(UIButton sender)
        {
            // Gets the text from the weight and height fields, 
            // converts them to doubles, and stores them in UserData
            UserData.Weight = Convert.ToDouble(txtWeight.Text);
            UserData.Height = Convert.ToDouble(txtHeight.Text);

            // Calculates BMI from Weight and Height variables and stores it
            UserData.BMI = (UserData.Weight / (UserData.Height * UserData.Height)) * 703;
        }
    }
}
