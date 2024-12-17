using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	public class FOnChaosRemovalEvents : FMulticastDelegate<Action<TArray<FChaosRemovalEventData>>>
	{
		public FOnChaosRemovalEvents() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnChaosRemovalEvents() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FChaosRemovalEventData> RemovalEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RemovalEvents?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
