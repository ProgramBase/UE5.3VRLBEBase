﻿using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EFloatArrayToIntArrayFunctionEnum")]
	public enum EFloatArrayToIntArrayFunctionEnum : byte
	{
		Dataflow_FloatToInt_Function_Floor = 0,
		Dataflow_FloatToInt_Function_Ceil = 1,
		Dataflow_FloatToInt_Function_Round = 2,
		Dataflow_FloatToInt_Function_Truncate = 3,
		Dataflow_FloatToInt_NonZeroToIndex = 4,
		Dataflow_FloatToInt_ZeroToIndex = 5,
		Dataflow_Max = 6,
	}
}