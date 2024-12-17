using Script.CoreUObject;

namespace Script.MaterialShaderQualitySettings
{
	[PathName("/Script/MaterialShaderQualitySettings.EMobileShadowQuality")]
	public enum EMobileShadowQuality : byte
	{
		NoFiltering = 0,
		PCF_1x1 = 1,
		PCF_3x3 = 2,
		PCF_5x5 = 3,
	}
}