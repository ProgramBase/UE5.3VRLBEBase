using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FActorEndPlaySignature : FMulticastDelegate<Action<AActor, EEndPlayReason>>
	{
		public FActorEndPlaySignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorEndPlaySignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor Actor, EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EndPlayReason;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
