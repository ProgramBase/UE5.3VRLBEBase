using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FActorComponentDeactivateSignature : FMulticastDelegate<Action<UActorComponent>>
	{
		public FActorComponentDeactivateSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorComponentDeactivateSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UActorComponent Component)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
