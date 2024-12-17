using Script.CoreUObject;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.ESpritePolygonMode")]
	public enum ESpritePolygonMode : byte
	{
		SourceBoundingBox = 0,
		TightBoundingBox = 1,
		ShrinkWrapped = 2,
		FullyCustom = 3,
		Diced = 4,
	}
}