using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EVertexColorPaintBrushOpBlendMode")]
	public enum EVertexColorPaintBrushOpBlendMode : int
	{
		Lerp = 0,
		Mix = 1,
		Multiply = 2,
	}
}