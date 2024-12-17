using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EMakeBoxDataTypeEnum")]
	public enum EMakeBoxDataTypeEnum : byte
	{
		Dataflow_MakeBox_DataType_MinMax = 0,
		Dataflow_MakeBox_DataType_CenterSize = 1,
		Dataflow_Max = 2,
	}
}