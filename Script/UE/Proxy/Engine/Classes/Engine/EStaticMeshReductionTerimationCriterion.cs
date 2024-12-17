using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EStaticMeshReductionTerimationCriterion")]
	public enum EStaticMeshReductionTerimationCriterion : byte
	{
		Triangles = 0,
		Vertices = 1,
		Any = 2,
	}
}