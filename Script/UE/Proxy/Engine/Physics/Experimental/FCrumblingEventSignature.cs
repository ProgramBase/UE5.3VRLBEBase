using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FCrumblingEventSignature : FMulticastDelegate<Action<TArray<FChaosCrumblingEvent>>>
	{
		public FCrumblingEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FCrumblingEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FChaosCrumblingEvent> CrumblingEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CrumblingEvents?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
