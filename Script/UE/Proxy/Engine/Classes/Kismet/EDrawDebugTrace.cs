using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDrawDebugTrace")]
	public enum EDrawDebugTrace : byte
	{
		None = 0,
		ForOneFrame = 1,
		ForDuration = 2,
		Persistent = 3,
	}
}