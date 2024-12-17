using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FInAppPurchaseQuery2Result : FMulticastDelegate<Action<TArray<FOnlineProxyStoreOffer>>>
	{
		public FInAppPurchaseQuery2Result() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FInAppPurchaseQuery2Result() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FOnlineProxyStoreOffer> InAppOfferInformation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAppOfferInformation?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
