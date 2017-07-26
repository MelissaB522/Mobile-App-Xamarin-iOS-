using System;

using UIKit;
using System.Net.NetworkInformation;
using iOSWebService.com.w3schools.www;
using iOSWebService.net.webservicex.www;

namespace iOSWebService
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
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

        partial void UIButton7_TouchUpInside(UIButton sender)
        {
            // Check for network availability
            bool check = NetworkInterface.GetIsNetworkAvailable();

            if (check)
            {
                //// They have a connection we can use
                //TempConvert client = new TempConvert();

                //// Called the method on web service
                //client.FahrenheitToCelsiusAsync(txtTemp.Text);

                //// Setup event handler that is listening for response
                //client.FahrenheitToCelsiusCompleted += client_FahrenheitToCelsiusCompleted;

                ConvertTemperature client1 = new ConvertTemperature();
                client1.ConvertTempAsync(Convert.ToDouble(txtTemp.Text), TemperatureUnit.degreeFahrenheit, TemperatureUnit.degreeCelsius);
                client1.ConvertTempCompleted += client_ConvertTempCompleted;

            }
            else
            {
                return;
            }


        }

        //public void client_FahrenheitToCelsiusCompleted(object sender, FahrenheitToCelsiusCompletedEventArgs e)
        //{
        //    // Take response and put it in label
        //    lblNewTemp.Text = e.Result;
        //}

        public void client_ConvertTempCompleted(object sender, ConvertTempCompletedEventArgs e)
        {
            // Take response and put it in label
            lblNewTemp.Text = e.Result.ToString();
        }
    }
}