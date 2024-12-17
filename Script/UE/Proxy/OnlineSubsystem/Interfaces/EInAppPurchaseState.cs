using Script.CoreUObject;

namespace Script.OnlineSubsystem
{
	[PathName("/Script/OnlineSubsystem.EInAppPurchaseState")]
	public enum EInAppPurchaseState : long
	{
		Unknown = 0,
		Success = 1,
		Failed = 2,
		Cancelled = 3,
		Invalid = 4,
		NotAllowed = 5,
		Restored = 6,
		AlreadyOwned = 7,
	}
}