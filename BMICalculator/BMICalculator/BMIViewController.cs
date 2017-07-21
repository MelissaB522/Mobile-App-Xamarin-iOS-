using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class BMIViewController : UIViewController
    {
        public BMIViewController (IntPtr handle) : base (handle)
        {

        }

		public override void ViewDidLoad()
		{
            // Overwrites the label with the calculated BMI rounded to 1 decimal place
            lblBMI.Text = Math.Round(UserData.BMI, 1).ToString();
		}


    }
}