using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace SoundboardApp
{
    class TableSource : UITableViewSource
    {
        protected string[] tableItems;
        protected string cellIdentifier = "TableCell";
        ViewController owner;

        public TableSource(string[] items)
        {
            tableItems = items;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var newViewController = (NewViewController)owner.Storyboard.InstantiateViewController("NewViewController");
            newViewController.SelectedRow = indexPath.Row;

            owner.NavigationController.PushViewController(newViewController, true);

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