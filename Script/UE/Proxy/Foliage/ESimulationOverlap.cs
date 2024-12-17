using Script.CoreUObject;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.ESimulationOverlap")]
	public enum ESimulationOverlap : long
	{
		CollisionOverlap = 0,
		ShadeOverlap = 1,
		None = 2,
	}
}