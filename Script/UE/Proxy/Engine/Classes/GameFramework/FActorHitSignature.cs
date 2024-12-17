using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FActorHitSignature : FMulticastDelegate<Action<AActor, AActor, FVector, FHitResult>>
	{
		public FActorHitSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorHitSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor SelfActor, AActor OtherActor, FVector NormalImpulse, FHitResult Hit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = SelfActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NormalImpulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
