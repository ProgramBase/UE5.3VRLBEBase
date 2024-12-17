using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EProcessRootMotionMode")]
	public enum EProcessRootMotionMode : byte
	{
		Ignore = 0,
		Loop = 1,
		LoopAndReset = 2,
	}
}