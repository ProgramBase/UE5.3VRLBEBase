using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine.PlatformGameInstance
{
	public class FPlatformReceivedRemoteNotificationDelegate : FMulticastDelegate<Action<FString, EApplicationState>>
	{
		public FPlatformReceivedRemoteNotificationDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlatformReceivedRemoteNotificationDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString inString, EApplicationState inAppState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = inString?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)inAppState;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
