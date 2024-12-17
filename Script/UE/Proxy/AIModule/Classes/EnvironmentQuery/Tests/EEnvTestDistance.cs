using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvTestDistance")]
	public enum EEnvTestDistance : byte
	{
		Distance3D = 0,
		Distance2D = 1,
		DistanceZ = 2,
		DistanceAbsoluteZ = 3,
	}
}