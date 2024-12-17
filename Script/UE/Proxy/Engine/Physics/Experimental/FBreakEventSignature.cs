using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FBreakEventSignature : FMulticastDelegate<Action<TArray<FChaosBreakEvent>>>
	{
		public FBreakEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FBreakEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FChaosBreakEvent> BreakEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BreakEvents?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
