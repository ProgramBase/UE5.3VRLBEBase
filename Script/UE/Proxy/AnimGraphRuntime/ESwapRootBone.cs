using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ESwapRootBone")]
	public enum ESwapRootBone : byte
	{
		SwapRootBone_Component = 0,
		SwapRootBone_Actor = 1,
		SwapRootBone_None = 2,
	}
}