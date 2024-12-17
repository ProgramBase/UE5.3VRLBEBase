using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EDataflowSetMaskConditionType")]
	public enum EDataflowSetMaskConditionType : byte
	{
		Dataflow_SetMaskConditionType_Always = 0,
		Dataflow_SetMaskConditionType_IFF_NOT_Interior = 1,
		Dataflow_SetMaskConditionType_IFF_NOT_Exterior = 2,
		Dataflow_Max = 3,
	}
}