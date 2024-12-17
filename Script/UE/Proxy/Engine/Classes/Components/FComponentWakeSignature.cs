using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FComponentWakeSignature : FMulticastDelegate<Action<UPrimitiveComponent, FName>>
	{
		public FComponentWakeSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FComponentWakeSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UPrimitiveComponent WakingComponent, FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WakingComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
