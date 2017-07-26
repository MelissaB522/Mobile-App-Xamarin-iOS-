using Foundation;
using System;
using UIKit;
using System.IO;

namespace StockQuoteApp
{
    public partial class ListController : UIViewController
    {
        public ListController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			// Retrieve info from file
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var filename = Path.Combine(documents, "StockSymbols.txt");
			var text = File.ReadAllText(filename);
            string[] symbols = text.Split(' ');

            // Instantiate new instance of TableSource
            TableData.Source = new TableSource(symbols, this);
        }

        public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}