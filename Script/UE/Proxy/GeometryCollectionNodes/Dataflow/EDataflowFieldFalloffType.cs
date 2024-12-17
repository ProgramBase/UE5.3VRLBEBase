using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EDataflowFieldFalloffType")]
	public enum EDataflowFieldFalloffType : byte
	{
		Dataflow_FieldFalloffType_None = 0,
		Dataflow_FieldFalloffType_Linear = 1,
		Dataflow_FieldFalloffType_Inverse = 2,
		Dataflow_FieldFalloffType_Squared = 3,
		Dataflow_FieldFalloffType_Logarithmic = 4,
		Dataflow_Max = 5,
	}
}