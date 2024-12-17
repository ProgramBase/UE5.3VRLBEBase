using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EReloadPackagesInteractionMode")]
	public enum EReloadPackagesInteractionMode : byte
	{
		Interactive = 0,
		AssumePositive = 1,
		AssumeNegative = 2,
	}
}