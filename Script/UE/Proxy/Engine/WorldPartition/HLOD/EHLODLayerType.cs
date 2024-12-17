using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EHLODLayerType")]
	public enum EHLODLayerType : byte
	{
		Instancing = 0,
		MeshMerge = 1,
		MeshSimplify = 2,
		MeshApproximate = 3,
		Custom = 4,
	}
}