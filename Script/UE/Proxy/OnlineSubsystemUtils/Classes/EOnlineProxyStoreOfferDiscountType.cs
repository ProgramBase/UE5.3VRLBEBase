using Script.CoreUObject;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.EOnlineProxyStoreOfferDiscountType")]
	public enum EOnlineProxyStoreOfferDiscountType : byte
	{
		NotOnSale = 0,
		Percentage = 1,
		DiscountAmount = 2,
		PayAmount = 3,
	}
}