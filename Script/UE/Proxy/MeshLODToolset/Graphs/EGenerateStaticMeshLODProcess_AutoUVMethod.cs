using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.EGenerateStaticMeshLODProcess_AutoUVMethod")]
	public enum EGenerateStaticMeshLODProcess_AutoUVMethod : byte
	{
		PatchBuilder = 0,
		UVAtlas = 1,
		XAtlas = 2,
	}
}