using System;
using UIKit;
using FDFullscreen;

namespace Xam_FDFullcreen
{
    public class MainViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Blue";
            this.View.BackgroundColor = UIColor.Blue;
            //this.NavigationController.SetNavigationBarHidden(true , false);
            this.SetFd_prefersNavigationBarHidden(true);

            UIButton button = new UIButton();
            button.SetTitle("Next", UIControlState.Normal);
            button.Frame = new CoreGraphics.CGRect(100,300,100,100);
            button.TouchUpInside += (sender, e) =>
            {
                this.NavigationController.PushViewController(new SecondViewController(), true);
            };

            this.View.AddSubview(button);
        }

    }
}
