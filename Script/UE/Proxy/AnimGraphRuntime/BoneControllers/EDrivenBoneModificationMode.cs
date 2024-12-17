using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EDrivenBoneModificationMode")]
	public enum EDrivenBoneModificationMode : byte
	{
		AddToInput = 0,
		ReplaceComponent = 1,
		AddToRefPose = 2,
	}
}