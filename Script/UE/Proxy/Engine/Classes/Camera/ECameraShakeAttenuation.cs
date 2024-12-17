using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECameraShakeAttenuation")]
	public enum ECameraShakeAttenuation : byte
	{
		Linear = 0,
		Quadratic = 1,
	}
}