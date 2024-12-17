using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAttachLocation")]
	public enum EAttachLocation : byte
	{
		KeepRelativeOffset = 0,
		KeepWorldPosition = 1,
		SnapToTarget = 2,
		SnapToTargetIncludingScale = 3,
	}
}