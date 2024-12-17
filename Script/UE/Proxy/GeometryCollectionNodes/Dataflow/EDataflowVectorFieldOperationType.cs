using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EDataflowVectorFieldOperationType")]
	public enum EDataflowVectorFieldOperationType : byte
	{
		Dataflow_VectorFieldOperationType_Multiply = 0,
		Dataflow_VectorFieldFalloffType_Divide = 1,
		Dataflow_VectorFieldFalloffType_Add = 2,
		Dataflow_VectorFieldFalloffType_Substract = 3,
		Dataflow_VectorFieldFalloffType_CrossProduct = 4,
		Dataflow_Max = 5,
	}
}