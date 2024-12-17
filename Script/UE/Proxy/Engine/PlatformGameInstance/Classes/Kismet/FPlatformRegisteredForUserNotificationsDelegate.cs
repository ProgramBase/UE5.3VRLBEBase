using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.PlatformGameInstance
{
	public class FPlatformRegisteredForUserNotificationsDelegate : FMulticastDelegate<Action<int>>
	{
		public FPlatformRegisteredForUserNotificationsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlatformRegisteredForUserNotificationsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int inInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = inInt;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
