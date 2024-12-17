using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvOverlapShape")]
	public enum EEnvOverlapShape : byte
	{
		Box = 0,
		Sphere = 1,
		Capsule = 2,
	}
}