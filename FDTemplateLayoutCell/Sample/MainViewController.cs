using System;
using UIKit;
using Newtonsoft.Json;
using FDTemplateLayoutCell;
using Foundation;
using System.IO;

namespace Sample
{
    [Register("MainViewController")]
    public class MainViewController : UITableViewController
    {
        private Feed[] Feeds { get; set; }
        private const string FeedIdentifier = "feedCell";
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.TableView.SetFd_debugLogEnabled(true);
            this.TableView.RegisterClassForCellReuse(typeof(FeedCell), FeedIdentifier);
            this.TableView.Delegate = this;
            this.TableView.DataSource = this;

            LoadJsonData(()=>{
                this.TableView.ReloadData();
            });
        }


        private void LoadJsonData(Action compeletion)
        {
            string dataFilePath = NSBundle.MainBundle.PathForResource("data", "json");
            using(var reader = new StreamReader(dataFilePath))
            {
                var jsonString = reader.ReadToEnd();
                FeedModel jsonData = JsonConvert.DeserializeObject<FeedModel>(jsonString);
                this.Feeds = jsonData.Feed;
                compeletion?.Invoke();
            }

        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return this.Feeds == null ? 0 : (nint)this.Feeds.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            FeedCell cell = tableView.DequeueReusableCell(FeedIdentifier, indexPath) as FeedCell;
            if (cell == null)
                cell = new FeedCell(FeedIdentifier);
            SetModelOfCell(cell, indexPath);

            return cell;
        }

        private void SetModelOfCell(FeedCell cell, NSIndexPath indexPath)
        {
            if (this.Feeds == null || this.Feeds.Length == 0)
                return;
            cell.Feed = this.Feeds[indexPath.Row];
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return this.TableView.Fd_heightForCellWithIdentifier(FeedIdentifier, indexPath, (cell)=>{
                if(cell is FeedCell feedCell)
                {
                    SetModelOfCell(feedCell, indexPath);
                }
            });
        }
    }
}
