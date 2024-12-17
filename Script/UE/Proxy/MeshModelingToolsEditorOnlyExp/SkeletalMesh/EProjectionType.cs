using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EProjectionType")]
	public enum EProjectionType : byte
	{
		CameraPlane = 0,
		OnMesh = 1,
		WithinMesh = 2,
	}
}