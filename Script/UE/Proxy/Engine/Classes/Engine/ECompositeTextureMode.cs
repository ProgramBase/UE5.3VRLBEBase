using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECompositeTextureMode")]
	public enum ECompositeTextureMode : byte
	{
		CTM_Disabled = 0,
		CTM_NormalRoughnessToRed = 1,
		CTM_NormalRoughnessToGreen = 2,
		CTM_NormalRoughnessToBlue = 3,
		CTM_NormalRoughnessToAlpha = 4,
	}
}