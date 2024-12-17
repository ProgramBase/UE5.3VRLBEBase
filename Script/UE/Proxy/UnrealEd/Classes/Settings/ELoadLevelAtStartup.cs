using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ELoadLevelAtStartup")]
	public enum ELoadLevelAtStartup : byte
	{
		None = 0,
		ProjectDefault = 1,
		LastOpened = 2,
	}
}