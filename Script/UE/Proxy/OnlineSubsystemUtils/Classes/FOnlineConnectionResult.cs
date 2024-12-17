using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FOnlineConnectionResult : FMulticastDelegate<Action<int>>
	{
		public FOnlineConnectionResult() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnlineConnectionResult() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int ErrorCode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ErrorCode;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
