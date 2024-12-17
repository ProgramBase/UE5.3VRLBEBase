using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.OnlineSubsystemUtils
{
	public class FOnlineLogoutResult : FMulticastDelegate<Action<APlayerController>>
	{
		public FOnlineLogoutResult() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnlineLogoutResult() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
