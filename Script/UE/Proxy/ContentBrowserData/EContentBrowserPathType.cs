using Script.CoreUObject;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.EContentBrowserPathType")]
	public enum EContentBrowserPathType : byte
	{
		None = 0,
		Internal = 1,
		Virtual = 2,
	}
}