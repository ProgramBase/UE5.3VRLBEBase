using Script.CoreUObject;

namespace Script.MeshPaint
{
	[PathName("/Script/MeshPaint.EMeshVertexPaintTarget")]
	public enum EMeshVertexPaintTarget : long
	{
		ComponentInstance = 0,
		Mesh = 1,
	}
}