using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FActorBeginOverlapSignature : FMulticastDelegate<Action<AActor, AActor>>
	{
		public FActorBeginOverlapSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorBeginOverlapSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor OverlappedActor, AActor OtherActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OverlappedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
