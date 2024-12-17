using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EComponentMobility")]
	public enum EComponentMobility : byte
	{
		Static = 0,
		Stationary = 1,
		Movable = 2,
	}
}