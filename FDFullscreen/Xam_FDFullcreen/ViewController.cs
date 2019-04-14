using System;

using UIKit;

namespace Xam_FDFullcreen
{
    public partial class ViewController : UIViewController
    {
        public ViewController()
        {

        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Black Page";
            this.View.BackgroundColor = UIColor.Black;


            UIButton button_nofd = new UIButton(UIButtonType.Custom)
            {
                Frame = new CoreGraphics.CGRect((UIScreen.MainScreen.Bounds.Width - 200) / 2, (UIScreen.MainScreen.Bounds.Height - 200) / 3, 200, 100)
            };
            button_nofd.SetTitle("Without FDFullScreen", UIControlState.Normal);
            button_nofd.SetTitleColor(UIColor.White, UIControlState.Normal);
            button_nofd.TouchUpInside += (sender, e) =>
            {
                this.NavigationController.PushViewController(new MainViewController(), true);
            };
            this.View.AddSubview(button_nofd);

            UIButton button = new UIButton(UIButtonType.Custom)
            {
                Frame = new CoreGraphics.CGRect((UIScreen.MainScreen.Bounds.Width - 200) / 2, (UIScreen.MainScreen.Bounds.Height + 100) / 3, 200, 100)
            };
            button.SetTitle("With FDFullScreen", UIControlState.Normal);
            button.SetTitleColor(UIColor.White, UIControlState.Normal);
            button.TouchUpInside += (sender, e) =>
            {
                this.NavigationController.PushViewController(new SecondViewController(), true);
            };
            this.View.AddSubview(button);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
