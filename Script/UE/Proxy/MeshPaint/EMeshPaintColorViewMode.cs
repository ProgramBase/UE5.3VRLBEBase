using Script.CoreUObject;

namespace Script.MeshPaint
{
	[PathName("/Script/MeshPaint.EMeshPaintColorViewMode")]
	public enum EMeshPaintColorViewMode : byte
	{
		Normal = 0,
		RGB = 1,
		Alpha = 2,
		Red = 3,
		Green = 4,
		Blue = 5,
	}
}