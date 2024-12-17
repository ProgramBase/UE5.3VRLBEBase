using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPingAverageType")]
	public enum EPingAverageType : long
	{
		None = 0,
		MovingAverage = 1,
		PlayerStateAvg = 2,
	}
}