using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.ESetOperationEnum")]
	public enum ESetOperationEnum : byte
	{
		Dataflow_SetOperation_AND = 0,
		Dataflow_SetOperation_OR = 1,
		Dataflow_SetOperation_XOR = 2,
		Dataflow_Max = 3,
	}
}