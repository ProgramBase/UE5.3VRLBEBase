using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FActorEndCursorOverSignature : FMulticastDelegate<Action<AActor>>
	{
		public FActorEndCursorOverSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorEndCursorOverSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor TouchedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TouchedActor?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
