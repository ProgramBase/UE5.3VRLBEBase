using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EDrawPolygonDrawMode")]
	public enum EDrawPolygonDrawMode : byte
	{
		Freehand = 0,
		Circle = 1,
		Square = 2,
		Rectangle = 3,
		RoundedRectangle = 4,
		Ring = 5,
	}
}