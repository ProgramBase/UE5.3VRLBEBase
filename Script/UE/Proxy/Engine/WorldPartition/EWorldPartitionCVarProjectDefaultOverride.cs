using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWorldPartitionCVarProjectDefaultOverride")]
	public enum EWorldPartitionCVarProjectDefaultOverride : byte
	{
		ProjectDefault = 0,
		Disabled = 1,
		Enabled = 2,
	}
}