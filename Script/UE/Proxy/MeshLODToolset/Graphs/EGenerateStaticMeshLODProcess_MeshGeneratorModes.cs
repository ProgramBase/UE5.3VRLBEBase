using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.EGenerateStaticMeshLODProcess_MeshGeneratorModes")]
	public enum EGenerateStaticMeshLODProcess_MeshGeneratorModes : byte
	{
		Solidify = 0,
		SolidifyAndClose = 1,
		CleanAndSimplify = 2,
		ConvexHull = 3,
	}
}