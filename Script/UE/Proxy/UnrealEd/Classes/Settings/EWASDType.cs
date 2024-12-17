using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EWASDType")]
	public enum EWASDType : byte
	{
		WASD_Always = 0,
		WASD_RMBOnly = 1,
		WASD_Never = 2,
	}
}