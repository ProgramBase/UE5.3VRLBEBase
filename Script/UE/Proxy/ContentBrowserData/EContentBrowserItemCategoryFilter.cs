using Script.CoreUObject;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.EContentBrowserItemCategoryFilter")]
	public enum EContentBrowserItemCategoryFilter : byte
	{
		IncludeNone = 0,
		IncludeAssets = 1,
		IncludeClasses = 2,
		IncludeCollections = 4,
		IncludeMisc = 8,
		IncludeAll = 15,
	}
}