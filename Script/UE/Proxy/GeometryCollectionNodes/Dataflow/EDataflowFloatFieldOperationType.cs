﻿using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EDataflowFloatFieldOperationType")]
	public enum EDataflowFloatFieldOperationType : byte
	{
		Dataflow_FloatFieldOperationType_Multiply = 0,
		Dataflow_FloatFieldFalloffType_Divide = 1,
		Dataflow_FloatFieldFalloffType_Add = 2,
		Dataflow_FloatFieldFalloffType_Substract = 3,
		Dataflow_FloatFieldFalloffType_Min = 4,
		Dataflow_FloatFieldFalloffType_Max = 5,
		Dataflow_Max = 6,
	}
}