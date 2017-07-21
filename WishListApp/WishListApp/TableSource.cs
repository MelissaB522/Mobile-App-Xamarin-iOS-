using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace WishListApp
{
    class TableSource : UITableViewSource
    {
        // Created arrays here so that each view controller can access them
        protected string[] tableItems;
        protected string[] itemURLs;
        protected UIImage[] itemImages;
        protected string cellIdentifier = "TableCell";
        ViewController owner;

        // Constuctor
        public TableSource(string[] items, string[] urls, UIImage[] images, ViewController owner)
        {
            tableItems = items;
            itemURLs = urls;
            itemImages = images;
            this.owner = owner;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return tableItems.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            // Instantiate newViewController
            var newViewController = (NewViewController)owner.Storyboard.InstantiateViewController("NewViewController");
            // Pass newViewController the selected row
            newViewController.SelectedRow = indexPath.Row;

            // Push newViewController onto the Navigation Controller
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