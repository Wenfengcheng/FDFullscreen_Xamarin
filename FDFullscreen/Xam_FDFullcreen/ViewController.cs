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
            this.Title = "Black";
            this.View.BackgroundColor = UIColor.Black;


            UIButton button = new UIButton(UIButtonType.Custom);
            button.Frame = new CoreGraphics.CGRect(100, 300, 100, 100);
            button.SetTitle("Next", UIControlState.Normal);
            button.SetTitleColor(UIColor.White, UIControlState.Normal);
            button.TouchUpInside += (sender, e) =>
            {
                this.NavigationController.PushViewController(new MainViewController(), true);
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
