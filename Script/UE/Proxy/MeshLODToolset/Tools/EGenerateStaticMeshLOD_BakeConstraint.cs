using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.EGenerateStaticMeshLOD_BakeConstraint")]
	public enum EGenerateStaticMeshLOD_BakeConstraint : int
	{
		NoConstraint = 0,
		DoNotBake = 1,
	}
}