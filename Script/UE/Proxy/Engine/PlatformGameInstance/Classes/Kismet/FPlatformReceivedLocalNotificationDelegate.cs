using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine.PlatformGameInstance
{
	public class FPlatformReceivedLocalNotificationDelegate : FMulticastDelegate<Action<FString, int, EApplicationState>>
	{
		public FPlatformReceivedLocalNotificationDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlatformReceivedLocalNotificationDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString inString, int inInt, EApplicationState inAppState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = inString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = inInt;

				*(byte*)(__InBuffer + 12) = (byte)inAppState;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
