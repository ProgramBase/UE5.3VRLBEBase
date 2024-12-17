using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ERefPoseType")]
	public enum ERefPoseType : byte
	{
		EIT_LocalSpace = 0,
		EIT_Additive = 1,
	}
}