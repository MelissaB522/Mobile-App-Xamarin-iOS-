using System;
using UIKit;
using Foundation;

namespace StockQuoteApp
{
    public class TableSource : UITableViewSource
    {
        protected string[] favSymbols;
        protected string cellIdentifier = "TableCell";
        ListController listController;

        // Constructor
        public TableSource(string[] symbols, ListController owner)
        {
            favSymbols = symbols;
            this.listController = owner;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return favSymbols.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            string newSymbol = favSymbols[indexPath.Row];
            UIAlertController alertController = UIAlertController.Create("Row Selected", newSymbol, UIAlertControllerStyle.Alert);
            // If user clicks Use Symbol, ViewController is re-opened and SelectedRow prop in ViewController is set to selected row
            alertController.AddAction(UIAlertAction.Create("Use Symbol", UIAlertActionStyle.Default, Action => {
				var viewController = (ViewController)listController.Storyboard.InstantiateViewController("ViewController");
                viewController.SelectedRow = newSymbol;
				listController.NavigationController.PushViewController(viewController, true);
            }));
            alertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Default, null));
            listController.PresentViewController(alertController, true, null);

            tableView.DeselectRow(indexPath, true);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            if(cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            }

            cell.TextLabel.Text = favSymbols[indexPath.Row];

            return cell;
        }
    }
}
