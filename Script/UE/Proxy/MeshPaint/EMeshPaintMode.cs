using Script.CoreUObject;

namespace Script.MeshPaint
{
	[PathName("/Script/MeshPaint.EMeshPaintMode")]
	public enum EMeshPaintMode : long
	{
		PaintColors = 0,
		PaintWeights = 1,
	}
}