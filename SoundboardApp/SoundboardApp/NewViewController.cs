using Foundation;
using System;
using UIKit;

namespace SoundboardApp
{
    public partial class NewViewController : UIViewController
    {
        public int SelectedRow { get; set; }

        public NewViewController (IntPtr handle) : base (handle)
        {
        }
    }
}