using System;

using UIKit;
using System.IO;

namespace AmtrakTrainsApp
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

        partial void UIButton109_TouchUpInside(UIButton sender)
        {
            // Validation for hour, cannot be over 23
            if (Convert.ToInt32(txtHour.Text) > 23)
            {
                var alert = UIAlertController.Create("Hour not valid", "Must be 1-23", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            }
            // Validation for minute, cannot be over 59
            else if (Convert.ToInt32(txtMinute.Text) > 59)
            {
				var alert = UIAlertController.Create("Minutes not valid", "Must be 1-59", UIAlertControllerStyle.Alert);
				alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
				PresentViewController(alert, true, null);
            }
            // Validation for length, cannot be over 1500
			else if (Convert.ToInt32(txtLength.Text) > 1500)
			{
				var alert = UIAlertController.Create("Length not valid", "Cannot be greater than 1500", UIAlertControllerStyle.Alert);
				alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
				PresentViewController(alert, true, null);
			}
            // If all fields validate, store info and clear text
            else
            {
                // Place user info in variables
                string departHour = txtHour.Text;
	            string departMinute = txtMinute.Text;
	            string tripLength = txtLength.Text;
	            string line = string.Format("{0}, {1}, {2}", departHour, departMinute, tripLength);

	            // Store information
	            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
	            var filename = Path.Combine(documents, "TrainTripInfo.txt");
	            File.WriteAllText(filename, line);

	            // Clear text for next entry
	            txtHour.Text = "";
	            txtMinute.Text = "";
	            txtLength.Text = "";
			}
        }
    }
}
