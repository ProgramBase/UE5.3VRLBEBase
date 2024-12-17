using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENetworkLagState")]
	public enum ENetworkLagState : long
	{
		NotLagging = 0,
		Lagging = 1,
	}
}