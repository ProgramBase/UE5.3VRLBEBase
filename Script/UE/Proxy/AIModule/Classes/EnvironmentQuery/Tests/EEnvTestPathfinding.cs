using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvTestPathfinding")]
	public enum EEnvTestPathfinding : byte
	{
		PathExist = 0,
		PathCost = 1,
		PathLength = 2,
	}
}