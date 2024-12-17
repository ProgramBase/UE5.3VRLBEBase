using Script.CoreUObject;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.EMeshPaintWeightTypes")]
	public enum EMeshPaintWeightTypes : byte
	{
		AlphaLerp = 2,
		RGB = 3,
		ARGB = 4,
		OneMinusARGB = 5,
	}
}