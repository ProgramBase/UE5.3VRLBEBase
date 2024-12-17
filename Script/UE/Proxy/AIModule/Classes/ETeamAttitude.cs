using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.ETeamAttitude")]
	public enum ETeamAttitude : long
	{
		Friendly = 0,
		Neutral = 1,
		Hostile = 2,
	}
}