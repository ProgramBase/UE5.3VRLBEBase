using Script.CoreUObject;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.ESimulationQuery")]
	public enum ESimulationQuery : long
	{
		None = 0,
		CollisionOverlap = 1,
		ShadeOverlap = 2,
		AnyOverlap = 3,
	}
}