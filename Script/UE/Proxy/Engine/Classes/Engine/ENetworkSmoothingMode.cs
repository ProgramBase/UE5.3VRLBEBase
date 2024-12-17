using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENetworkSmoothingMode")]
	public enum ENetworkSmoothingMode : byte
	{
		Disabled = 0,
		Linear = 1,
		Exponential = 2,
	}
}