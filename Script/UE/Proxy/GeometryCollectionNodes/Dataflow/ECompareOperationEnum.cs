using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.ECompareOperationEnum")]
	public enum ECompareOperationEnum : byte
	{
		Dataflow_Compare_Equal = 0,
		Dataflow_Compare_Smaller = 1,
		Dataflow_Compare_SmallerOrEqual = 2,
		Dataflow_Compare_Greater = 3,
		Dataflow_Compare_GreaterOrEqual = 4,
		Dataflow_Max = 5,
	}
}