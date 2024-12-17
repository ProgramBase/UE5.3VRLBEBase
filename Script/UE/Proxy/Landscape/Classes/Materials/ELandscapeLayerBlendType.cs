using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeLayerBlendType")]
	public enum ELandscapeLayerBlendType : byte
	{
		LB_WeightBlend = 0,
		LB_AlphaBlend = 1,
		LB_HeightBlend = 2,
	}
}