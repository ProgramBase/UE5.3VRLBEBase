using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FActorComponentActivatedSignature : FMulticastDelegate<Action<UActorComponent, bool>>
	{
		public FActorComponentActivatedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorComponentActivatedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UActorComponent Component, bool bReset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bReset;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
