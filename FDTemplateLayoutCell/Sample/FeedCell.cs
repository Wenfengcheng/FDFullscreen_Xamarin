using System;
using UIKit;
using Masonry;
using Foundation;

namespace Sample
{
    [Register("FeedCell")]
    public class FeedCell : UITableViewCell
    {
        private Feed _feed;
        public Feed Feed
        {
            get => _feed;
            set{
                _feed = value;
                if (value == null)
                    return;
                this.TitleLabel.Text = value.Title;
                this.ContentLabel.Text = value.Content;
                this.ContentImageView.Image = string.IsNullOrWhiteSpace(value.ImageName) ? null : UIImage.FromFile(value.ImageName);
                this.UserLabel.Text = value.UserName;
                this.TimeLabel.Text = value.Time;
            }
        }

        private UILabel TitleLabel { get; set; }
        private UILabel ContentLabel { get; set; }
        private UIImageView ContentImageView { get; set; }
        private UILabel UserLabel { get; set; }
        private UILabel TimeLabel { get; set; }

        public FeedCell(string reuseIdentifier):base(UITableViewCellStyle.Default, reuseIdentifier)
        {
            CreateView();
            SettingViewAutoLayout();
        }

        public FeedCell(NSString reuseIdentifier) : base(UITableViewCellStyle.Default, reuseIdentifier)
        {
            CreateView();
            SettingViewAutoLayout();
        }

        public FeedCell(IntPtr intPtr):base(intPtr)
        {
            CreateView();
            SettingViewAutoLayout();
        }

        private void CreateView()
        {
            UILabel titleLabel = new UILabel();
            this.ContentView.AddSubview(titleLabel);
            this.TitleLabel = titleLabel;

            UILabel contentlabel = new UILabel()
            {
                Lines = 0
            };
            this.ContentView.AddSubview(contentlabel);
            this.ContentLabel = contentlabel;

            UIImageView contentImageView = new UIImageView()
            {
                ContentMode = UIViewContentMode.ScaleAspectFit
            };
            this.ContentView.AddSubview(contentImageView);
            this.ContentImageView = contentImageView;

            UILabel userLabel = new UILabel();
            this.ContentView.AddSubview(userLabel);
            this.UserLabel = userLabel;

            UILabel timeLabel = new UILabel();
            this.ContentView.AddSubview(timeLabel);
            this.TimeLabel = timeLabel;
        }

        private void SettingViewAutoLayout()
        {
            int margin = 4;
            int padding = 10;

            this.TitleLabel.MakeConstraints(make =>{
                make.Top.And.Left.EqualTo(this.ContentView).With.Offset(padding);
                make.Right.EqualTo(this.ContentView.Right()).With.Offset(-padding);
            });

            this.ContentLabel.MakeConstraints(make => {
                make.Left.And.Right.EqualTo(this.TitleLabel);
                make.Top.EqualTo(this.TitleLabel.Bottom()).With.Offset(margin);
            });

            this.ContentImageView.MakeConstraints(make => {
                make.Left.EqualTo(this.TitleLabel.Left());
                make.Top.EqualTo(this.ContentLabel.Bottom()).With.Offset(margin);
            });

            this.UserLabel.MakeConstraints(make => {
                make.Left.EqualTo(this.TitleLabel.Left());
                make.Top.EqualTo(this.ContentImageView.Bottom()).With.Offset(margin);
                make.Bottom.EqualTo(this.ContentView.Bottom()).With.Offset(-margin);
            });

            this.TimeLabel.MakeConstraints(make => {
                make.Bottom.And.Top.EqualTo(this.UserLabel);
                make.Right.EqualTo(this.TitleLabel.Right());
            });
        }

    }
}
