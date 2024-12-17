using System;
using Script.CoreUObject;
using Script.Library;
using Script.InputCore;

namespace Script.Engine
{
	public class FComponentOnReleasedSignature : FMulticastDelegate<Action<UPrimitiveComponent, FKey>>
	{
		public FComponentOnReleasedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FComponentOnReleasedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UPrimitiveComponent TouchedComponent, FKey ButtonReleased)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TouchedComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ButtonReleased?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
