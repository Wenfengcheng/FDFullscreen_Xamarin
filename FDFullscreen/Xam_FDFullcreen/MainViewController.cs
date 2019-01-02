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
            this.SetFd_prefersNavigationBarHidden(true);

            UIButton button = new UIButton();
            button.SetTitle("To Next Page", UIControlState.Normal);
            button.SetTitleColor(UIColor.White, UIControlState.Normal);
            button.Frame = new CoreGraphics.CGRect((UIScreen.MainScreen.Bounds.Width - 300) / 2, (UIScreen.MainScreen.Bounds.Height - 100) / 2, 300, 100);
            button.TouchUpInside += (sender, e) =>
            {
                this.NavigationController.PushViewController(new SecondViewController(), true);
            };

            this.View.AddSubview(button);
        }

    }
}
