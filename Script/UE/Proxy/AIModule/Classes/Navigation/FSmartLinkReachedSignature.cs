using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	public class FSmartLinkReachedSignature : FMulticastDelegate<Action<AActor, FVector>>
	{
		public FSmartLinkReachedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FSmartLinkReachedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor MovingActor, FVector DestinationPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MovingActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationPoint?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
