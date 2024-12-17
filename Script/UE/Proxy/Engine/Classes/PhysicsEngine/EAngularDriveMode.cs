using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAngularDriveMode")]
	public enum EAngularDriveMode : byte
	{
		SLERP = 0,
		TwistAndSwing = 1,
	}
}