using Script.CoreUObject;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.ENavCostDisplay")]
	public enum ENavCostDisplay : byte
	{
		TotalCost = 0,
		HeuristicOnly = 1,
		RealCostOnly = 2,
	}
}