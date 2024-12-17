using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EVisibilityAggressiveness")]
	public enum EVisibilityAggressiveness : byte
	{
		VIS_LeastAggressive = 0,
		VIS_ModeratelyAggressive = 1,
		VIS_MostAggressive = 2,
		VIS_Max = 3,
	}
}