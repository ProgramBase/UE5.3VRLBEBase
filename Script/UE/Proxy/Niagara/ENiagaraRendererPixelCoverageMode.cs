using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraRendererPixelCoverageMode")]
	public enum ENiagaraRendererPixelCoverageMode : byte
	{
		Automatic = 0,
		Disabled = 1,
		Enabled = 2,
		Enabled_RGBA = 3,
		Enabled_RGB = 4,
		Enabled_A = 5,
	}
}