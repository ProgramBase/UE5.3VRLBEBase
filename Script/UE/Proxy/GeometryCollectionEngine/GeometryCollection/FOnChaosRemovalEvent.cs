using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GeometryCollectionEngine
{
	public class FOnChaosRemovalEvent : FMulticastDelegate<Action<FChaosRemovalEvent>>
	{
		public FOnChaosRemovalEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnChaosRemovalEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FChaosRemovalEvent RemovalEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RemovalEvent?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
