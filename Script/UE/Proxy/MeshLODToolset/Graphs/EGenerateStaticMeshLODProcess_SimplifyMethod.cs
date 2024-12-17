using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.EGenerateStaticMeshLODProcess_SimplifyMethod")]
	public enum EGenerateStaticMeshLODProcess_SimplifyMethod : byte
	{
		TriangleCount = 0,
		VertexCount = 1,
		TrianglePercentage = 2,
		GeometricTolerance = 3,
	}
}