using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FOnLeaderboardFlushed : FMulticastDelegate<Action<FName>>
	{
		public FOnLeaderboardFlushed() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLeaderboardFlushed() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FName SessionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SessionName?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
