using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraDebugHUDDOverviewSort")]
	public enum ENiagaraDebugHUDDOverviewSort : int
	{
		Name = 0,
		NumberRegistered = 1,
		NumberActive = 2,
		NumberScalability = 3,
		MemoryUsage = 4,
		RecentlyVisibilty = 5,
	}
}