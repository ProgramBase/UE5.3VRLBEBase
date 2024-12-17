using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.CopyBoneDeltaMode")]
	public enum CopyBoneDeltaMode : byte
	{
		Accumulate = 0,
		Copy = 1,
	}
}