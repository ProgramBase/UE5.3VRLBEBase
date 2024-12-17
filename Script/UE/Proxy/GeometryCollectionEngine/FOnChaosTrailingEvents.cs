using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	public class FOnChaosTrailingEvents : FMulticastDelegate<Action<TArray<FChaosTrailingEventData>>>
	{
		public FOnChaosTrailingEvents() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnChaosTrailingEvents() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FChaosTrailingEventData> TrailingEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TrailingEvents?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
