using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.ESelectSubjectTypeEnum")]
	public enum ESelectSubjectTypeEnum : byte
	{
		Dataflow_SelectSubjectType_Vertices = 0,
		Dataflow_SelectSubjectType_BoundingBox = 1,
		Dataflow_SelectSubjectType_Centroid = 2,
		Dataflow_Max = 3,
	}
}