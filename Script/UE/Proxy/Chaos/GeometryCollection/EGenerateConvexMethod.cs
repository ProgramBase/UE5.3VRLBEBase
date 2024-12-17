using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EGenerateConvexMethod")]
	public enum EGenerateConvexMethod : byte
	{
		ExternalCollision = 0,
		ComputedFromGeometry = 1,
		IntersectExternalWithComputed = 2,
	}
}