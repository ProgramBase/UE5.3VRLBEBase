using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EConnectionContactAreaMethodEnum")]
	public enum EConnectionContactAreaMethodEnum : byte
	{
		Dataflow_ConnectionContactAreaMethod_None = 0,
		Dataflow_ProximityContactFilteringMethod_ConvexHullArea = 1,
		Dataflow_Max = 2,
	}
}