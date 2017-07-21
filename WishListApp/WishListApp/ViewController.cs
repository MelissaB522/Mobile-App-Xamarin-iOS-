using System;

using UIKit;

namespace WishListApp
{
    public partial class ViewController : UIViewController
    {
        // Create arrays to hold all the information needed for each item in the table
        public static string[] items = new string[] { "Winning Lotto Ticket", "Speks", "Adopt an Orca", "Dream House", "Castles!" };
        public static string[] urls = new string[] { "http://www.molottery.com/", "https://www.getspeks.com/",
                  "https://whalemuseum.org/collections/adopt-an-orca",
                  "https://www.zillow.com/homedetails/151-Storm-Ridge-Rd-Friday-Harbor-WA-98250/72286485_zpid/?fullpage=true",
                  "http://europeancastlestours.com/" };
        public static UIImage[] images = new UIImage[] {UIImage.FromBundle("lotto.jpeg"), UIImage.FromBundle("speks.jpg"),
            UIImage.FromBundle("Adoptorca.jpg"), UIImage.FromBundle("dreamhouse.jpg"), UIImage.FromBundle("neuschwanstein.jpg") };

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            // Instantiate TableSource and pass arrays to it
            TableData.Source = new TableSource(items, urls, images, this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}