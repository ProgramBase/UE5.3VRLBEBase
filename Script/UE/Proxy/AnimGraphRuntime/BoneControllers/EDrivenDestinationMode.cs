using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EDrivenDestinationMode")]
	public enum EDrivenDestinationMode : byte
	{
		Bone = 0,
		MorphTarget = 1,
		MaterialParameter = 2,
	}
}