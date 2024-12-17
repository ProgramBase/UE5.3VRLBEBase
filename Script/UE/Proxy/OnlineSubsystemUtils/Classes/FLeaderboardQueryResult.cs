using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FLeaderboardQueryResult : FMulticastDelegate<Action<int>>
	{
		public FLeaderboardQueryResult() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FLeaderboardQueryResult() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int LeaderboardValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = LeaderboardValue;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
