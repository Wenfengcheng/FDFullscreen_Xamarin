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
        /// <summary>
        /// The gesture recognizer that actually handles interactive pop.
        /// </summary>
        // @property (readonly, nonatomic, strong) UIPanGestureRecognizer * fd_fullscreenPopGestureRecognizer;
        [Export("fd_fullscreenPopGestureRecognizer", ArgumentSemantic.Strong)]
        UIPanGestureRecognizer Fd_fullscreenPopGestureRecognizer();

        /// <summary>
        /// A view controller is able to control navigation bar's appearance by itself,
        /// </summary>
        // @property (assign, nonatomic) BOOL fd_viewControllerBasedNavigationBarAppearanceEnabled;
        [Export("fd_viewControllerBasedNavigationBarAppearanceEnabled")]
        bool Fd_viewControllerBasedNavigationBarAppearanceEnabled();

        /// <summary>
        /// A view controller is able to control navigation bar's appearance by itself,
        /// </summary>
        [Export("setFd_viewControllerBasedNavigationBarAppearanceEnabled:")]
        void SetFd_viewControllerBasedNavigationBarAppearanceEnabled(bool enabled);
    }

    // @interface FDFullscreenPopGesture (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_FDFullscreenPopGesture
    {
        /// <summary>
        /// Whether the interactive pop gesture is disabled when contained in a navigation stack.
        /// </summary>
        // @property (assign, nonatomic) BOOL fd_interactivePopDisabled;
        [Export("fd_interactivePopDisabled")]
        bool Fd_interactivePopDisabled();

        /// <summary>
        /// Whether the interactive pop gesture is disabled when contained in a navigation stack.
        /// </summary>
        [Export("setFd_interactivePopDisabled:")]
        void SetFd_interactivePopDisabled(bool disable);

        /// <summary>
        /// Indicate this view controller prefers its navigation bar hidden or not,
        /// </summary>
        // @property (assign, nonatomic) BOOL fd_prefersNavigationBarHidden;
        [Export("fd_prefersNavigationBarHidden")]
        bool Fd_prefersNavigationBarHidden();

        /// <summary>
        /// Indicate this view controller prefers its navigation bar hidden or not,
        /// </summary>
        [Export("setFd_prefersNavigationBarHidden:")]
        void SetFd_prefersNavigationBarHidden(bool hidden);
    }
}

