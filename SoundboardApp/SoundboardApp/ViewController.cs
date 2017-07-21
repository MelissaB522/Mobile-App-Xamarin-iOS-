using System;

using UIKit;

namespace SoundboardApp
{
    public partial class ViewController : UIViewController
    {
        public static string[] items = new string[] { "Drums", "Future Content" };

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            TableData.Source = new TableSource(items);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}