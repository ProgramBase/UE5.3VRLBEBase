using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAttachmentRule")]
	public enum EAttachmentRule : byte
	{
		KeepRelative = 0,
		KeepWorld = 1,
		SnapToTarget = 2,
	}
}