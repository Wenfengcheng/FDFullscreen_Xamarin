using System;
using UIKit;


namespace Xam_FDFullcreen
{
    public class MainViewController : UIViewController, IUIGestureRecognizerDelegate
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Blue";
            this.View.BackgroundColor = UIColor.Blue;

            /*
             * Without FDFullScreenPopGesture:
             * We should enable popgesture manually by setting delegate  
            */
            this.NavigationController.InteractivePopGestureRecognizer.Delegate = this;

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

        /*
         * Without FDFullScreenPopGesture:
         * We should hide navigationbar manually on ViewWillAppear   
        */
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if(this.NavigationController != null)
            {
                this.NavigationController.SetNavigationBarHidden(true, animated);
            }

        }

        /*
         * Without FDFullScreenPopGesture:
         * We should show navigationbar manually on ViewWillDisappear   
        */
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            if (this.NavigationController != null)
            {
                this.NavigationController.SetNavigationBarHidden(false, animated);
            }
        }

    }
}
