using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshTerminationCriterion")]
	public enum SkeletalMeshTerminationCriterion : byte
	{
		SMTC_NumOfTriangles = 0,
		SMTC_NumOfVerts = 1,
		SMTC_TriangleOrVert = 2,
		SMTC_AbsNumOfTriangles = 3,
		SMTC_AbsNumOfVerts = 4,
		SMTC_AbsTriangleOrVert = 5,
	}
}