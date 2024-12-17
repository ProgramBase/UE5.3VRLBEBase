using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FComponentEndOverlapSignature : FMulticastDelegate<Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>>
	{
		public FComponentEndOverlapSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FComponentEndOverlapSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = OverlappedComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OtherComp?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = OtherBodyIndex;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
