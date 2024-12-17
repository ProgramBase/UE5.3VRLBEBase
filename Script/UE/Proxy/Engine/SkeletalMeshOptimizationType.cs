using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshOptimizationType")]
	public enum SkeletalMeshOptimizationType : byte
	{
		SMOT_NumOfTriangles = 0,
		SMOT_MaxDeviation = 1,
		SMOT_TriangleOrDeviation = 2,
	}
}