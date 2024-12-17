using Script.CoreUObject;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.EContentBrowserItemAttributeFilter")]
	public enum EContentBrowserItemAttributeFilter : byte
	{
		IncludeNone = 0,
		IncludeProject = 1,
		IncludeEngine = 2,
		IncludePlugins = 4,
		IncludeDeveloper = 8,
		IncludeLocalized = 16,
		IncludeAll = 31,
	}
}