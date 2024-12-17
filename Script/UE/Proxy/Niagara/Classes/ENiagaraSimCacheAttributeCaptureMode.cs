using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraSimCacheAttributeCaptureMode")]
	public enum ENiagaraSimCacheAttributeCaptureMode : byte
	{
		All = 0,
		RenderingOnly = 1,
		ExplicitAttributes = 2,
	}
}