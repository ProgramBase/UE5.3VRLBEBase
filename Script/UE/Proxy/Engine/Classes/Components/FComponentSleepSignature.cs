using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FComponentSleepSignature : FMulticastDelegate<Action<UPrimitiveComponent, FName>>
	{
		public FComponentSleepSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FComponentSleepSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UPrimitiveComponent SleepingComponent, FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SleepingComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
