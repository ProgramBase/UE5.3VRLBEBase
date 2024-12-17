using Script.CoreUObject;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.ETileMapProjectionMode")]
	public enum ETileMapProjectionMode : byte
	{
		Orthogonal = 0,
		IsometricDiamond = 1,
		IsometricStaggered = 2,
		HexagonalStaggered = 3,
	}
}