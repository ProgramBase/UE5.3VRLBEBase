using Script.CoreUObject;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.EMeshPaintDataColorViewMode")]
	public enum EMeshPaintDataColorViewMode : byte
	{
		Normal = 0,
		RGB = 1,
		Alpha = 2,
		Red = 3,
		Green = 4,
		Blue = 5,
	}
}