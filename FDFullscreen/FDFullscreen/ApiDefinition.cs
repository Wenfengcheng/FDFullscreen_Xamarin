using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace FDFullscreen
{

    // @interface FDFullscreenPopGesture (UINavigationController)
    [Category]
    [BaseType(typeof(UINavigationController))]
    interface UINavigationController_FDFullscreenPopGesture
    {
        // @property (readonly, nonatomic, strong) UIPanGestureRecognizer * fd_fullscreenPopGestureRecognizer;
        [Export("fd_fullscreenPopGestureRecognizer", ArgumentSemantic.Strong)]
        UIPanGestureRecognizer Fd_fullscreenPopGestureRecognizer();

        // @property (assign, nonatomic) BOOL fd_viewControllerBasedNavigationBarAppearanceEnabled;
        [Export("fd_viewControllerBasedNavigationBarAppearanceEnabled")]
        bool Fd_viewControllerBasedNavigationBarAppearanceEnabled();

        [Export("setFd_viewControllerBasedNavigationBarAppearanceEnabled:")]
        void SetFd_viewControllerBasedNavigationBarAppearanceEnabled(bool enabled);
    }

    // @interface FDFullscreenPopGesture (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_FDFullscreenPopGesture
    {
            // @property (assign, nonatomic) BOOL fd_interactivePopDisabled;
        [Export("fd_interactivePopDisabled")]
        bool Fd_interactivePopDisabled();

        [Export("setFd_interactivePopDisabled:")]
        void SetFd_interactivePopDisabled(bool disable);

        // @property (assign, nonatomic) BOOL fd_prefersNavigationBarHidden;
        [Export("fd_prefersNavigationBarHidden")]
        bool Fd_prefersNavigationBarHidden();

        [Export("setFd_prefersNavigationBarHidden:")]
        void SetFd_prefersNavigationBarHidden(bool hidden);
    }

}

