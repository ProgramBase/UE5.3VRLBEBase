using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ESkeletonDrawMode")]
	public enum ESkeletonDrawMode : byte
	{
		Default = 0,
		Hidden = 1,
		GreyedOut = 2,
	}
}