using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EConvexOverlapRemovalMethodEnum")]
	public enum EConvexOverlapRemovalMethodEnum : byte
	{
		Dataflow_EConvexOverlapRemovalMethod_None = 0,
		Dataflow_EConvexOverlapRemovalMethod_All = 1,
		Dataflow_EConvexOverlapRemovalMethod_OnlyClusters = 2,
		Dataflow_EConvexOverlapRemovalMethod_OnlyClustersVsClusters = 3,
		Dataflow_Max = 4,
	}
}