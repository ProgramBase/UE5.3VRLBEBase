using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.ERotationOrderEnum")]
	public enum ERotationOrderEnum : byte
	{
		Dataflow_RotationOrder_XYZ = 0,
		Dataflow_RotationOrder_YZX = 1,
		Dataflow_RotationOrder_ZXY = 2,
		Dataflow_RotationOrder_XZY = 3,
		Dataflow_RotationOrder_YXZ = 4,
		Dataflow_RotationOrder_ZYX = 5,
		Dataflow_Max = 6,
	}
}