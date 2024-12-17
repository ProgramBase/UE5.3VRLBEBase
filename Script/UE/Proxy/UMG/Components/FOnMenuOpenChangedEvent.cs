using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnMenuOpenChangedEvent : FMulticastDelegate<Action<bool>>
	{
		public FOnMenuOpenChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMenuOpenChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(bool bIsOpen)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsOpen;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
