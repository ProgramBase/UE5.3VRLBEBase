using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaxConcurrentResolutionRule")]
	public enum EMaxConcurrentResolutionRule : byte
	{
		PreventNew = 0,
		StopOldest = 1,
		StopFarthestThenPreventNew = 2,
		StopFarthestThenOldest = 3,
		StopLowestPriority = 4,
		StopQuietest = 5,
		StopLowestPriorityThenPreventNew = 6,
		Count = 7,
	}
}