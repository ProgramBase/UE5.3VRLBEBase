using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EComponentPhysicsStateChange")]
	public enum EComponentPhysicsStateChange : byte
	{
		Created = 0,
		Destroyed = 1,
	}
}