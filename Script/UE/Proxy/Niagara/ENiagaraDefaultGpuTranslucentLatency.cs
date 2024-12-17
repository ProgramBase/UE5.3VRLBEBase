using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraDefaultGpuTranslucentLatency")]
	public enum ENiagaraDefaultGpuTranslucentLatency : byte
	{
		Immediate = 0,
		Latent = 1,
	}
}