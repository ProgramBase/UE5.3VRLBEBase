using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraGpuSyncMode")]
	public enum ENiagaraGpuSyncMode : int
	{
		None = 0,
		SyncCpuToGpu = 1,
		SyncGpuToCpu = 2,
		SyncBoth = 3,
	}
}