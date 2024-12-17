using Script.CoreUObject;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.EBeaconConnectionState")]
	public enum EBeaconConnectionState : byte
	{
		Invalid = 0,
		Closed = 1,
		Pending = 2,
		Open = 3,
	}
}