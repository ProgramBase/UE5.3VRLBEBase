using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWorldPartitionStreamingPerformance")]
	public enum EWorldPartitionStreamingPerformance : long
	{
		Good = 0,
		Slow = 1,
		Critical = 2,
	}
}