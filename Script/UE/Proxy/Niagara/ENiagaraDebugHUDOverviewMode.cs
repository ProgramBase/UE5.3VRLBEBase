using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraDebugHUDOverviewMode")]
	public enum ENiagaraDebugHUDOverviewMode : int
	{
		Overview = 0,
		Scalability = 1,
		Performance = 2,
		PerformanceGraph = 3,
		GpuComputePerformance = 4,
	}
}