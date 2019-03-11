using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace FDTemplateLayoutCell
{
    // @interface FDIndexPathHeightCache : NSObject
    [BaseType(typeof(NSObject))]
    interface FDIndexPathHeightCache
    {
        // @property (assign, nonatomic) BOOL automaticallyInvalidateEnabled;
        [Export("automaticallyInvalidateEnabled")]
        bool AutomaticallyInvalidateEnabled { get; set; }

        // -(BOOL)existsHeightAtIndexPath:(NSIndexPath *)indexPath;
        [Export("existsHeightAtIndexPath:")]
        bool ExistsHeightAtIndexPath(NSIndexPath indexPath);

        // -(void)cacheHeight:(CGFloat)height byIndexPath:(NSIndexPath *)indexPath;
        [Export("cacheHeight:byIndexPath:")]
        void CacheHeight(nfloat height, NSIndexPath indexPath);

        // -(CGFloat)heightForIndexPath:(NSIndexPath *)indexPath;
        [Export("heightForIndexPath:")]
        nfloat HeightForIndexPath(NSIndexPath indexPath);

        // -(void)invalidateHeightAtIndexPath:(NSIndexPath *)indexPath;
        [Export("invalidateHeightAtIndexPath:")]
        void InvalidateHeightAtIndexPath(NSIndexPath indexPath);

        // -(void)invalidateAllHeightCache;
        [Export("invalidateAllHeightCache")]
        void InvalidateAllHeightCache();
    }

    // @interface FDIndexPathHeightCache (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_FDIndexPathHeightCache
    {
        // @property (readonly, nonatomic, strong) FDIndexPathHeightCache * fd_indexPathHeightCache;
        [Export("fd_indexPathHeightCache", ArgumentSemantic.Strong)]
        FDIndexPathHeightCache Fd_indexPathHeightCache();
    }

    // @interface FDIndexPathHeightCacheInvalidation (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_FDIndexPathHeightCacheInvalidation
    {
        // -(void)fd_reloadDataWithoutInvalidateIndexPathHeightCache;
        [Export("fd_reloadDataWithoutInvalidateIndexPathHeightCache")]
        void Fd_reloadDataWithoutInvalidateIndexPathHeightCache();
    }

    // @interface FDKeyedHeightCache : NSObject
    [BaseType(typeof(NSObject))]
    interface FDKeyedHeightCache
    {
        // -(BOOL)existsHeightForKey:(id<NSCopying>)key;
        [Export("existsHeightForKey:")]
        bool ExistsHeightForKey(NSCopying key);

        // -(void)cacheHeight:(CGFloat)height byKey:(id<NSCopying>)key;
        [Export("cacheHeight:byKey:")]
        void CacheHeight(nfloat height, NSCopying key);

        // -(CGFloat)heightForKey:(id<NSCopying>)key;
        [Export("heightForKey:")]
        nfloat HeightForKey(NSCopying key);

        // -(void)invalidateHeightForKey:(id<NSCopying>)key;
        [Export("invalidateHeightForKey:")]
        void InvalidateHeightForKey(NSCopying key);

        // -(void)invalidateAllHeightCache;
        [Export("invalidateAllHeightCache")]
        void InvalidateAllHeightCache();
    }

    // @interface FDKeyedHeightCache (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_FDKeyedHeightCache
    {
        // @property (readonly, nonatomic, strong) FDKeyedHeightCache * fd_keyedHeightCache;
        [Export("fd_keyedHeightCache", ArgumentSemantic.Strong)]
        FDKeyedHeightCache Fd_keyedHeightCache();
    }

    // @interface FDTemplateLayoutCellDebug (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_FDTemplateLayoutCellDebug
    {
        // @property (assign, nonatomic) BOOL fd_debugLogEnabled;
        [Export("fd_debugLogEnabled")]
        bool Fd_debugLogEnabled();

        // @property (assign, nonatomic) BOOL fd_debugLogEnabled;
        [Export("setFd_debugLogEnabled:")]
        void SetFd_debugLogEnabled(bool enabled);

        // -(void)fd_debugLog:(NSString *)message;
        [Export("fd_debugLog:")]
        void Fd_debugLog(string message);
    }

    // @interface FDTemplateLayoutCell (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_FDTemplateLayoutCell
    {
        // -(__kindof UITableViewCell *)fd_templateCellForReuseIdentifier:(NSString *)identifier;
        [Export("fd_templateCellForReuseIdentifier:")]
        UITableViewCell Fd_templateCellForReuseIdentifier(string identifier);

        // -(CGFloat)fd_heightForCellWithIdentifier:(NSString *)identifier configuration:(void (^)(id))configuration;
        [Export("fd_heightForCellWithIdentifier:configuration:")]
        nfloat Fd_heightForCellWithIdentifier(string identifier, Action<NSObject> configuration);

        // -(CGFloat)fd_heightForCellWithIdentifier:(NSString *)identifier cacheByIndexPath:(NSIndexPath *)indexPath configuration:(void (^)(id))configuration;
        [Export("fd_heightForCellWithIdentifier:cacheByIndexPath:configuration:")]
        nfloat Fd_heightForCellWithIdentifier(string identifier, NSIndexPath indexPath, Action<NSObject> configuration);

        // -(CGFloat)fd_heightForCellWithIdentifier:(NSString *)identifier cacheByKey:(id<NSCopying>)key configuration:(void (^)(id))configuration;
        [Export("fd_heightForCellWithIdentifier:cacheByKey:configuration:")]
        nfloat Fd_heightForCellWithIdentifier(string identifier, NSCopying key, Action<NSObject> configuration);
    }

    // @interface FDTemplateLayoutHeaderFooterView (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_FDTemplateLayoutHeaderFooterView
    {
        // -(CGFloat)fd_heightForHeaderFooterViewWithIdentifier:(NSString *)identifier configuration:(void (^)(id))configuration;
        [Export("fd_heightForHeaderFooterViewWithIdentifier:configuration:")]
        nfloat Fd_heightForHeaderFooterViewWithIdentifier(string identifier, Action<NSObject> configuration);
    }

    // @interface FDTemplateLayoutCell (UITableViewCell)
    [Category]
    [BaseType(typeof(UITableViewCell))]
    interface UITableViewCell_FDTemplateLayoutCell
    {
        // @property (assign, nonatomic) BOOL fd_isTemplateLayoutCell;
        [Export("fd_isTemplateLayoutCell")]
        bool Fd_isTemplateLayoutCell();

        // @property (assign, nonatomic) BOOL fd_isTemplateLayoutCell;
        [Export("setFd_isTemplateLayoutCell:")]
        void SetFd_isTemplateLayoutCell(bool @true);

        // @property (assign, nonatomic) BOOL fd_enforceFrameLayout;
        [Export("fd_enforceFrameLayout")]
        bool Fd_enforceFrameLayout();

        // @property (assign, nonatomic) BOOL fd_isTemplateLayoutCell;
        [Export("setFd_enforceFrameLayout:")]
        void SetFd_enforceFrameLayout(bool @true);
    }
}
