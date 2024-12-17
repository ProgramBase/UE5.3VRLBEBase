using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FInAppPurchaseResult2 : FMulticastDelegate<Action<EInAppPurchaseStatus, TArray<FInAppPurchaseReceiptInfo2>>>
	{
		public FInAppPurchaseResult2() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FInAppPurchaseResult2() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
