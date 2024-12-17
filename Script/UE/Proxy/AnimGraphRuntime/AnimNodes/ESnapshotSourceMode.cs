using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ESnapshotSourceMode")]
	public enum ESnapshotSourceMode : byte
	{
		NamedSnapshot = 0,
		SnapshotPin = 1,
	}
}