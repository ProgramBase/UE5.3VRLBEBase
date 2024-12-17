using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EFloatToIntFunctionEnum")]
	public enum EFloatToIntFunctionEnum : byte
	{
		Dataflow_FloatToInt_Function_Floor = 0,
		Dataflow_FloatToInt_Function_Ceil = 1,
		Dataflow_FloatToInt_Function_Round = 2,
		Dataflow_FloatToInt_Function_Truncate = 3,
		Dataflow_Max = 4,
	}
}