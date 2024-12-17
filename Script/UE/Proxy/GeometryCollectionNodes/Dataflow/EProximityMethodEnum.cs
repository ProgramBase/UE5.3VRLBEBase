using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EProximityMethodEnum")]
	public enum EProximityMethodEnum : byte
	{
		Dataflow_ProximityMethod_Precise = 0,
		Dataflow_ProximityMethod_ConvexHull = 1,
		Dataflow_Max = 2,
	}
}