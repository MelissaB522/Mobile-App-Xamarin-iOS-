using Foundation;
using System;
using UIKit;
using System.IO;

namespace iOSDataStorage
{
    public partial class ListController : UIViewController
    {
        public ListController (IntPtr handle) : base (handle)
        {
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // Retrieve info from file
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename = Path.Combine(documents, "MyContacts.txt");
            var text = File.ReadAllText(filename);
            string[] line = text.Split(',');

            Contact myContact = new Contact(line[0], line[1]);

            // Create array of items 
            Contact[] contactList = { myContact };

            // Add array as source to table
            ContactTable.Source = new TableSource(contactList, this);
        }
    }
}