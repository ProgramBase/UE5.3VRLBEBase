using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.ESetMaterialOperationTypeEnum")]
	public enum ESetMaterialOperationTypeEnum : byte
	{
		Dataflow_SetMaterialOperationType_Add = 0,
		Dataflow_SetMaterialOperationType_Insert = 1,
		Dataflow_Max = 2,
	}
}