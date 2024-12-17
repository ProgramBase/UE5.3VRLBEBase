using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPasteTo")]
	public enum EPasteTo : long
	{
		PT_OriginalLocation = 0,
		PT_Here = 1,
		PT_WorldOrigin = 2,
	}
}