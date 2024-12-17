using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnVisibilityChangedEvent : FMulticastDelegate<Action<ESlateVisibility>>
	{
		public FOnVisibilityChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnVisibilityChangedEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(ESlateVisibility InVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InVisibility;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
