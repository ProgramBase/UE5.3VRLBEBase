using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ESetMeshMaterialMode")]
	public enum ESetMeshMaterialMode : byte
	{
		Original = 0,
		Checkerboard = 1,
		Override = 2,
	}
}