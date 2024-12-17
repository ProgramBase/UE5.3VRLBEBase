using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EMeshBooleanOperationEnum")]
	public enum EMeshBooleanOperationEnum : byte
	{
		Dataflow_MeshBoolean_Union = 0,
		Dataflow_MeshBoolean_Intersect = 1,
		Dataflow_MeshBoolean_Difference = 2,
		Dataflow_Max = 3,
	}
}