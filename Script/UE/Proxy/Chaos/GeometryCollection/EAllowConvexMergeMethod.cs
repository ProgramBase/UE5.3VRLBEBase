using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EAllowConvexMergeMethod")]
	public enum EAllowConvexMergeMethod : byte
	{
		ByProximity = 0,
		Any = 1,
	}
}