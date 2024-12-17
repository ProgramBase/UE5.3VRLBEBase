using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraRendererMotionVectorSetting")]
	public enum ENiagaraRendererMotionVectorSetting : int
	{
		AutoDetect = 0,
		Precise = 1,
		Approximate = 2,
		Disable = 3,
	}
}