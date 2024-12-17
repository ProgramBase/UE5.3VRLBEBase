using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EISMEditorTransformMode")]
	public enum EISMEditorTransformMode : byte
	{
		SharedGizmo = 0,
		SharedGizmoLocal = 1,
		PerObjectGizmo = 2,
		LastValue = 3,
	}
}