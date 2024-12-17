using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECameraShakeDurationType")]
	public enum ECameraShakeDurationType : byte
	{
		Fixed = 0,
		Infinite = 1,
		Custom = 2,
	}
}