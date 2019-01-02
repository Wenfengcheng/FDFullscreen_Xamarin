using System;
using UIKit;


namespace Xam_FDFullcreen
{
    public class SecondViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Red Page";
            this.View.BackgroundColor = UIColor.Red;
        }

    }
}
