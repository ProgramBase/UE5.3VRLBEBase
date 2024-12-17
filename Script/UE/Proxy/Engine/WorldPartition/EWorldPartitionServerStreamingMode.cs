using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWorldPartitionServerStreamingMode")]
	public enum EWorldPartitionServerStreamingMode : byte
	{
		ProjectDefault = 0,
		Disabled = 1,
		Enabled = 2,
		EnabledInPIE = 3,
	}
}