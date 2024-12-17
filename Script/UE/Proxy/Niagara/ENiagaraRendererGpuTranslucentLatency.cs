using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraRendererGpuTranslucentLatency")]
	public enum ENiagaraRendererGpuTranslucentLatency : byte
	{
		ProjectDefault = 0,
		Immediate = 1,
		Latent = 2,
	}
}