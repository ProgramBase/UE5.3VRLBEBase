using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FOnlineProxyInAppReceiptsResult : FMulticastDelegate<Action<EInAppPurchaseStatus, TArray<FInAppPurchaseReceiptInfo2>>>
	{
		public FOnlineProxyInAppReceiptsResult() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnlineProxyInAppReceiptsResult() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(EInAppPurchaseStatus PurchaseStatus, TArray<FInAppPurchaseReceiptInfo2> InAppPurchaseReceipts)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)PurchaseStatus;

				*(nint*)(__InBuffer + 1) = InAppPurchaseReceipts?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
