using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAnimSyncMethod")]
	public enum EAnimSyncMethod : byte
	{
		DoNotSync = 0,
		SyncGroup = 1,
		Graph = 2,
	}
}