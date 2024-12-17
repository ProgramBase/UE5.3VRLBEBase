using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FInAppPurchaseRestoreResult2 : FMulticastDelegate<Action<EInAppPurchaseStatus, TArray<FInAppPurchaseRestoreInfo2>>>
	{
		public FInAppPurchaseRestoreResult2() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FInAppPurchaseRestoreResult2() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(EInAppPurchaseStatus PurchaseStatus, TArray<FInAppPurchaseRestoreInfo2> InAppPurchaseRestoreInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)PurchaseStatus;

				*(nint*)(__InBuffer + 1) = InAppPurchaseRestoreInfo?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
