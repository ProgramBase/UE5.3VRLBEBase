using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FOnlineProxyInAppCheckoutResult : FMulticastDelegate<Action<EInAppPurchaseStatus, FInAppPurchaseReceiptInfo2>>
	{
		public FOnlineProxyInAppCheckoutResult() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnlineProxyInAppCheckoutResult() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(EInAppPurchaseStatus PurchaseStatus, FInAppPurchaseReceiptInfo2 InAppPurchaseReceipt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)PurchaseStatus;

				*(nint*)(__InBuffer + 1) = InAppPurchaseReceipt?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
