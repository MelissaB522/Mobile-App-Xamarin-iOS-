using System;
using UIKit;
using Foundation;

namespace iOSLists
{
    public class TableSource : UITableViewSource
    {
        protected string[] tableItems;
        protected string cellIdentifier = "TableCell";
        ViewController owner;

        public TableSource(string[] items, ViewController owner)
        {
            tableItems = items;
            this.owner = owner;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIAlertController alertController = UIAlertController.Create("Row Selected", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
            alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            owner.PresentViewController(alertController, true, null);

            UIApplication.SharedApplication.OpenUrl(new NSUrl("https://www.google.com/#q=" + tableItems[indexPath.Row]));

            tableView.DeselectRow(indexPath, true);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            }

            cell.TextLabel.Text = tableItems[indexPath.Row];

            return cell;
        }
    }
}
