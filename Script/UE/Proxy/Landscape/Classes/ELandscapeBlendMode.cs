using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeBlendMode")]
	public enum ELandscapeBlendMode : byte
	{
		LSBM_AdditiveBlend = 0,
		LSBM_AlphaBlend = 1,
	}
}