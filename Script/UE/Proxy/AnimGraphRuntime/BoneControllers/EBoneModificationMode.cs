using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EBoneModificationMode")]
	public enum EBoneModificationMode : byte
	{
		BMM_Ignore = 0,
		BMM_Replace = 1,
		BMM_Additive = 2,
	}
}