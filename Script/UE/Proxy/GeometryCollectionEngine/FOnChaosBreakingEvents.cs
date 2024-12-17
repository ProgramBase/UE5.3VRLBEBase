using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	public class FOnChaosBreakingEvents : FMulticastDelegate<Action<TArray<FChaosBreakingEventData>>>
	{
		public FOnChaosBreakingEvents() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnChaosBreakingEvents() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FChaosBreakingEventData> BreakingEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BreakingEvents?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
