using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Foundation;

namespace iOSDataStorage
{
    class TableSource : UITableViewSource
    {
        protected Contact[] tableItems;
        protected string cellIdentifier = "TableCell";
        ListController owner;

        public TableSource(Contact[] items, ListController owner)
        {
            tableItems = items;
            this.owner = owner;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return tableItems.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIAlertController alertController = UIAlertController.Create("Row Selected", tableItems[indexPath.Row].ToString(), UIAlertControllerStyle.Alert);
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

            cell.TextLabel.Text = tableItems[indexPath.Row].ToString();

            return cell;
        }
    }
}
