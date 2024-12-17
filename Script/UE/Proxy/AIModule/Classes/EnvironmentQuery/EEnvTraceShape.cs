using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvTraceShape")]
	public enum EEnvTraceShape : byte
	{
		Line = 0,
		Box = 1,
		Sphere = 2,
		Capsule = 3,
	}
}