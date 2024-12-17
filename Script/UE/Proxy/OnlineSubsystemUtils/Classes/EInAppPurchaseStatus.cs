using Script.CoreUObject;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.EInAppPurchaseStatus")]
	public enum EInAppPurchaseStatus : byte
	{
		Invalid = 0,
		Failed = 1,
		Deferred = 2,
		Canceled = 3,
		Purchased = 4,
		Restored = 5,
	}
}