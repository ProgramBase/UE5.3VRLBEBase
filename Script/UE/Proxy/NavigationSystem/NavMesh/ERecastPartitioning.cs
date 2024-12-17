using Script.CoreUObject;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.ERecastPartitioning")]
	public enum ERecastPartitioning : byte
	{
		Monotone = 0,
		Watershed = 1,
		ChunkyMonotone = 2,
	}
}