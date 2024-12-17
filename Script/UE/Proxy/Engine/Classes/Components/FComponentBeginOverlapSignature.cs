using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FComponentBeginOverlapSignature : FMulticastDelegate<Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>>
	{
		public FComponentBeginOverlapSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FComponentBeginOverlapSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = OverlappedComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OtherComp?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = OtherBodyIndex;

				*(bool*)(__InBuffer + 28) = bFromSweep;

				*(nint*)(__InBuffer + 29) = SweepResult?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
