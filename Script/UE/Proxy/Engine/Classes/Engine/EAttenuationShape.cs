using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAttenuationShape")]
	public enum EAttenuationShape : byte
	{
		Sphere = 0,
		Capsule = 1,
		Box = 2,
		Cone = 3,
	}
}