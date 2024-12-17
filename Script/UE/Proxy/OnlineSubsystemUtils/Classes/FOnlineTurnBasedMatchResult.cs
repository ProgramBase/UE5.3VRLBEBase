using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FOnlineTurnBasedMatchResult : FMulticastDelegate<Action<FString>>
	{
		public FOnlineTurnBasedMatchResult() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnlineTurnBasedMatchResult() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString MatchID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MatchID?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
