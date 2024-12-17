using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESoundDistanceCalc")]
	public enum ESoundDistanceCalc : long
	{
		SOUNDDISTANCE_Normal = 0,
		SOUNDDISTANCE_InfiniteXYPlane = 1,
		SOUNDDISTANCE_InfiniteXZPlane = 2,
		SOUNDDISTANCE_InfiniteYZPlane = 3,
	}
}