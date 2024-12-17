using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshVertexPaintBrushType")]
	public enum EMeshVertexPaintBrushType : byte
	{
		Paint = 0,
		Erase = 1,
		Soften = 2,
		Smooth = 3,
		LastValue = 4,
	}
}