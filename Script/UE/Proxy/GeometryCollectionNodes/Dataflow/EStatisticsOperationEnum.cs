using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EStatisticsOperationEnum")]
	public enum EStatisticsOperationEnum : byte
	{
		Dataflow_EStatisticsOperationEnum_Min = 0,
		Dataflow_EStatisticsOperationEnum_Max = 1,
		Dataflow_EStatisticsOperationEnum_Mean = 2,
		Dataflow_EStatisticsOperationEnum_Median = 3,
		Dataflow_EStatisticsOperationEnum_Mode = 4,
		Dataflow_EStatisticsOperationEnum_Sum = 5,
		Dataflow_Max = 6,
	}
}