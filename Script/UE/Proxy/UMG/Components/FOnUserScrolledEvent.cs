using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnUserScrolledEvent : FMulticastDelegate<Action<float>>
	{
		public FOnUserScrolledEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnUserScrolledEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float CurrentOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = CurrentOffset;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
