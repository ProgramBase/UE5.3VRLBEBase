using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EStreamingSourcePriority")]
	public enum EStreamingSourcePriority : byte
	{
		Highest = 0,
		High = 64,
		Normal = 128,
		Low = 192,
		Lowest = 255,
		Default = 128,
	}
}