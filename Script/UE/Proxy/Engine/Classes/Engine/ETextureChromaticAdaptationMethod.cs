using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureChromaticAdaptationMethod")]
	public enum ETextureChromaticAdaptationMethod : byte
	{
		TCAM_None = 0,
		TCAM_Bradford = 1,
		TCAM_CAT02 = 2,
	}
}