using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.PlatformGameInstance
{
	public class FPlatformFailedToRegisterForRemoteNotificationsDelegate : FMulticastDelegate<Action<FString>>
	{
		public FPlatformFailedToRegisterForRemoteNotificationsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlatformFailedToRegisterForRemoteNotificationsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString inString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = inString?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
