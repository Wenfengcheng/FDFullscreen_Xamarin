using System;
using UIKit;
using FDFullscreen;

namespace Xam_FDFullcreen
{
    public class SecondViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Red Page";
            this.View.BackgroundColor = UIColor.Red;

            /*
             * With FDFullScreenPopGesture:
             * We only need to call SetFd_prefersNavigationBarHidden(true).
             * This ViewController will be able to use fullscreen pop gesture and hide/show navigation bar automatically
            */
            this.SetFd_prefersNavigationBarHidden(true);
        }

    }
}
