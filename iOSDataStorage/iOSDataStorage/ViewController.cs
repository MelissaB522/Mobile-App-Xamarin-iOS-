using System;

using UIKit;
using System.IO;

namespace iOSDataStorage
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

        partial void BtnAdd_TouchUpInside(UIButton sender)
        {
            string name = tfName.Text;
            string phone = tfPhone.Text;
            string line = string.Format("{0},{1}", name, phone);

            // Store information
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename = Path.Combine(documents, "MyContacts.txt");
            File.WriteAllText(filename, line);
            
            var alert = UIAlertController.Create("Confirm", "Contact Added", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);

            // Clear out boxes
            tfName.Text = "";
            tfPhone.Text = "";
        }
    }
}