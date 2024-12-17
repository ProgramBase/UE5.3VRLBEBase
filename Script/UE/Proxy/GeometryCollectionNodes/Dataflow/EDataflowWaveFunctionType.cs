using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EDataflowWaveFunctionType")]
	public enum EDataflowWaveFunctionType : byte
	{
		Dataflow_WaveFunctionType_Cosine = 0,
		Dataflow_WaveFunctionType_Gaussian = 1,
		Dataflow_WaveFunctionType_Falloff = 2,
		Dataflow_WaveFunctionType_Decay = 3,
		Dataflow_Max = 4,
	}
}