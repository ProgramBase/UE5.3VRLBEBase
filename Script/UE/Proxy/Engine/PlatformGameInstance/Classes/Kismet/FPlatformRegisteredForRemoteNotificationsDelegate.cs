using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.PlatformGameInstance
{
	public class FPlatformRegisteredForRemoteNotificationsDelegate : FMulticastDelegate<Action<TArray<byte>>>
	{
		public FPlatformRegisteredForRemoteNotificationsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlatformRegisteredForRemoteNotificationsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<byte> inArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = inArray?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
