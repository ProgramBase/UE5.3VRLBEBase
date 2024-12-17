using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ETransformMeshesTransformMode")]
	public enum ETransformMeshesTransformMode : byte
	{
		SharedGizmo = 0,
		SharedGizmoLocal = 1,
		PerObjectGizmo = 2,
		LastValue = 3,
	}
}