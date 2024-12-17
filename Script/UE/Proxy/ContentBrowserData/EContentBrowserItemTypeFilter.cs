using Script.CoreUObject;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.EContentBrowserItemTypeFilter")]
	public enum EContentBrowserItemTypeFilter : byte
	{
		IncludeNone = 0,
		IncludeFolders = 1,
		IncludeFiles = 2,
		IncludeAll = 3,
	}
}