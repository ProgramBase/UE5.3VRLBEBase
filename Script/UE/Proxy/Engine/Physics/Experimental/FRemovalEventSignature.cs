using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FRemovalEventSignature : FMulticastDelegate<Action<TArray<FChaosRemovalEvent>>>
	{
		public FRemovalEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FRemovalEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FChaosRemovalEvent> RemovalEvents)
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
