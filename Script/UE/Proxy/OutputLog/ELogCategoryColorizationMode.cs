using Script.CoreUObject;

namespace Script.OutputLog
{
	[PathName("/Script/OutputLog.ELogCategoryColorizationMode")]
	public enum ELogCategoryColorizationMode : byte
	{
		None = 0,
		ColorizeWholeLine = 1,
		ColorizeCategoryOnly = 2,
		ColorizeCategoryAsBadge = 3,
	}
}