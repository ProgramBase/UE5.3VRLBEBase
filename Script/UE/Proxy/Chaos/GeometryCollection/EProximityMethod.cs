using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EProximityMethod")]
	public enum EProximityMethod : int
	{
		Precise = 0,
		ConvexHull = 1,
	}
}