using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EMeshToVolumeMode")]
	public enum EMeshToVolumeMode : int
	{
		TriangulatePolygons = 0,
		MinimalPolygons = 1,
	}
}