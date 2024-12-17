using System;
using Script.CoreUObject;
using Script.Library;
using Script.InputCore;

namespace Script.Engine
{
	public class FActorOnReleasedSignature : FMulticastDelegate<Action<AActor, FKey>>
	{
		public FActorOnReleasedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorOnReleasedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor TouchedActor, FKey ButtonReleased)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TouchedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ButtonReleased?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
