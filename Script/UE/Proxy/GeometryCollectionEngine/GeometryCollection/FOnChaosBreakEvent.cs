using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GeometryCollectionEngine
{
	public class FOnChaosBreakEvent : FMulticastDelegate<Action<FChaosBreakEvent>>
	{
		public FOnChaosBreakEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnChaosBreakEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FChaosBreakEvent BreakEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BreakEvent?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
