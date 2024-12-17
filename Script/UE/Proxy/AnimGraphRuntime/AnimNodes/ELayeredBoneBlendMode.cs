using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ELayeredBoneBlendMode")]
	public enum ELayeredBoneBlendMode : byte
	{
		BranchFilter = 0,
		BlendMask = 1,
	}
}