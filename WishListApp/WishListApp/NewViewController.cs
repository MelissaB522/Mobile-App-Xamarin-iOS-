using Foundation;
using System;
using UIKit;

namespace WishListApp
{
    public partial class NewViewController : UIViewController
    {
        public int SelectedRow { get; set; }

        public NewViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            // The label text is replaced with the correct item name from the item array, based on selected row
            lblItem.Text = ViewController.items[SelectedRow];
            // The image is replaced with the correct image from the array, based on selected row
            ivImage.Image = ViewController.images[SelectedRow];
        }

        partial void BtnFetch_TouchUpInside(UIButton sender)
        {
            // The fetch button goes to the appropriate URL from the array, based on selected row
            UIApplication.SharedApplication.OpenUrl(new NSUrl(ViewController.urls[SelectedRow]));
        }
    }
}