using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EProximityContactMethod")]
	public enum EProximityContactMethod : byte
	{
		MinOverlapInProjectionToMajorAxes = 0,
		ConvexHullSharpContact = 1,
		ConvexHullAreaContact = 2,
	}
}