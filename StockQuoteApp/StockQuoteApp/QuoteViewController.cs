using Foundation;
using System;
using UIKit;

namespace StockQuoteApp
{
    public partial class QuoteViewController : UIViewController
    {
        public QuoteViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // Fill labels with information from Quote instance received from web service
            lblName.Text = Quote.Name;
            lblValue.Text = Quote.CurrentValue.ToString();
            lblChange.Text = Quote.Change;
            lblHigh.Text = Quote.High.ToString();
            lblLow.Text = Quote.Low.ToString();
		}
    }
}