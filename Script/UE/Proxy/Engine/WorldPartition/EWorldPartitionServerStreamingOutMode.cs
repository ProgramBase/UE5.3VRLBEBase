using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWorldPartitionServerStreamingOutMode")]
	public enum EWorldPartitionServerStreamingOutMode : byte
	{
		ProjectDefault = 0,
		Disabled = 1,
		Enabled = 2,
	}
}