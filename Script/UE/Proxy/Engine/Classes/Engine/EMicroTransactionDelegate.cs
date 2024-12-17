using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMicroTransactionDelegate")]
	public enum EMicroTransactionDelegate : long
	{
		MTD_PurchaseQueryComplete = 0,
		MTD_PurchaseComplete = 1,
	}
}