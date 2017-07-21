using Foundation;
using System;
using UIKit;
using System.IO;

namespace AmtrakTrainsApp
{
    public partial class NewViewController : UIViewController
    {
        public NewViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Retrieve information from text file
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var filename = Path.Combine(documents, "TrainTripInfo.txt");
            var text = File.ReadAllText(filename);
            string[] line = text.Split(',');

            // Create departure datetime based on times in array
            DateTime depart = new DateTime(1, 1, 1, Convert.ToInt32(line[0]), Convert.ToInt32(line[1]), 1);
            // Create arrival datetime by adding length in minutes to departure datetime
            DateTime arrival = depart.AddMinutes(Convert.ToDouble(line[2]));

            // Add leading 0 to hour where required
			if (arrival.Hour.ToString().Length == 1)
			{
				txtArrivalHour.Text = "0" + arrival.Hour.ToString();
			}
			else
			{
                txtArrivalHour.Text = arrival.Hour.ToString();   
            }

            // Add leading 0 to minutes where required
            if(arrival.Minute.ToString().Length == 1)
            {
                txtArrivalMinute.Text = "0" + arrival.Minute.ToString();
            }
            else
            {
                txtArrivalMinute.Text = arrival.Minute.ToString();
            }

            // If arrival is between midnight and 6am, show Red Eye label and image
            if(arrival.Hour < 6 && arrival.Hour >= 0)
            {
                imgRedEye.Hidden = false;
                lblRedEye.Hidden = false;
                txtArrivalHour.TextColor = UIColor.Red;
                txtArrivalMinute.TextColor = UIColor.Red;
            }
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}