using Script.CoreUObject;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.ETexturePaintWeightTypes")]
	public enum ETexturePaintWeightTypes : long
	{
		AlphaLerp = 2,
		RGB = 3,
		ARGB = 4,
		OneMinusARGB = 5,
	}
}