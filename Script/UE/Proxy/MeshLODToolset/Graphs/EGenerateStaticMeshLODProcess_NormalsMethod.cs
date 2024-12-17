using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.EGenerateStaticMeshLODProcess_NormalsMethod")]
	public enum EGenerateStaticMeshLODProcess_NormalsMethod : byte
	{
		FromAngleThreshold = 0,
		PerVertex = 1,
		PerTriangle = 2,
	}
}