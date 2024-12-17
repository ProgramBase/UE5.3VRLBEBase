using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERootMotionMode")]
	public enum ERootMotionMode : byte
	{
		NoRootMotionExtraction = 0,
		IgnoreRootMotion = 1,
		RootMotionFromEverything = 2,
		RootMotionFromMontagesOnly = 3,
	}
}