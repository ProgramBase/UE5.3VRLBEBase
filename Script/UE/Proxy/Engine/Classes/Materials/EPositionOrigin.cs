using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPositionOrigin")]
	public enum EPositionOrigin : byte
	{
		Absolute = 0,
		CameraRelative = 1,
	}
}