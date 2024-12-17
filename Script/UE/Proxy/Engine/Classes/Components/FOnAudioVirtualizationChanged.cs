using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnAudioVirtualizationChanged : FMulticastDelegate<Action<bool>>
	{
		public FOnAudioVirtualizationChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAudioVirtualizationChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(bool bIsVirtualized)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsVirtualized;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
