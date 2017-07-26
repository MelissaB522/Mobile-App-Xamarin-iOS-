using System;

using UIKit;
using System.Net.NetworkInformation;
using StockQuoteApp.com.cdyne.ws;
using System.IO;

namespace StockQuoteApp
{
    public partial class ViewController : UIViewController
    {
        string symbol;
        public string SelectedRow { get; set; }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            if (SelectedRow != null)
            {
                txtSymbol.Text = SelectedRow;
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        // Get Quote button click event
        partial void BtnGetQuote_TouchUpInside(UIButton sender)
        {
            // Boolean variable to determine if network is available
            bool check = NetworkInterface.GetIsNetworkAvailable();

            if(check)
            {
                DelayedStockQuote client = new DelayedStockQuote();
                symbol = txtSymbol.Text;
                string license = "0";

                // Validation on text field, no null allowed
                if (txtSymbol.Text == "")
                {
                    // Alert if text field is null
                    var alert = UIAlertController.Create("Error", "You must enter a stock symbol", UIAlertControllerStyle.Alert);
                    alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                    PresentViewController(alert, true, null);
                }
                else
                {
                    // Call method on web service
                    client.GetQuoteAsync(symbol, license);
                    
                    // Setup event handler to listen for response
                    client.GetQuoteCompleted += Client_GetQuoteCompleted;
                }
            }
            else
            {
                return;
            }
        }

        // Add to Favorites button click event
        partial void BtnAdd_TouchUpInside(UIButton sender)
        {
            // Store symbol in variable
            string symbol = txtSymbol.Text;
            string line = string.Format("{0} ", symbol);

            // Store variable in text file
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename = Path.Combine(documents, "StockSymbols.txt");
            File.AppendAllText(filename, line);

            // Alert to confirm addition
            var alert = UIAlertController.Create("Confirm", "Symbol Added", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);
        }
		
		partial void BtnView_TouchUpInside(UIButton sender)
		{
		}

        public void Client_GetQuoteCompleted(object sender, GetQuoteCompletedEventArgs e)
        {

            // Try catch block for results from web service, if symbol is invalid it is caught and an alert is presented
            try
            {
				// Store results in variables
				string name = e.Result.CompanyName;
				decimal amount = e.Result.LastTradeAmount;
				string change = e.Result.ChangePercent;
				decimal high = e.Result.DayHigh;
				decimal low = e.Result.DayLow;

                // Create new instance of Quote to store results
				Quote newQuote = new Quote(name, amount, change, high, low);
            }
            catch (Exception)
            {
				// Invalid symbol alert
                var alert = UIAlertController.Create("Error", "Invalid Stock Symbol", UIAlertControllerStyle.Alert);
				alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
				PresentViewController(alert, true, null);
            }

            // Instantiate quoteViewController
			var quoteViewController = (QuoteViewController)this.Storyboard.InstantiateViewController("QuoteViewController");
			// Push quoteViewContoller onto NavigationController, where results from web service are displayed
            this.NavigationController.PushViewController(quoteViewController, true);
        }
    }
}