using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDetachmentRule")]
	public enum EDetachmentRule : byte
	{
		KeepRelative = 0,
		KeepWorld = 1,
	}
}