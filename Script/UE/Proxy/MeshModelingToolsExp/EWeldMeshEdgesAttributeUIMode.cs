using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EWeldMeshEdgesAttributeUIMode")]
	public enum EWeldMeshEdgesAttributeUIMode : byte
	{
		None = 0,
		OnWeldedMeshEdgesOnly = 1,
		OnFullMesh = 2,
	}
}