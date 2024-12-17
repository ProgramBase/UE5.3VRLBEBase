using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EProximityContactFilteringMethodEnum")]
	public enum EProximityContactFilteringMethodEnum : byte
	{
		Dataflow_ProximityContactFilteringMethod_ProjectedBoundsOverlap = 0,
		Dataflow_ProximityContactFilteringMethod_ConvexHullSharp = 1,
		Dataflow_ProximityContactFilteringMethod_ConvexHullArea = 2,
		Dataflow_Max = 3,
	}
}