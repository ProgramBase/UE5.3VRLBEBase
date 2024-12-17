using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	public class FOnNavDataGenericEvent : FMulticastDelegate<Action<ANavigationData>>
	{
		public FOnNavDataGenericEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnNavDataGenericEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(ANavigationData NavData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NavData?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
