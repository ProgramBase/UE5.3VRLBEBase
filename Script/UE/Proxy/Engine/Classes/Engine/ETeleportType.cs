using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETeleportType")]
	public enum ETeleportType : byte
	{
		None = 0,
		TeleportPhysics = 1,
		ResetPhysics = 2,
	}
}