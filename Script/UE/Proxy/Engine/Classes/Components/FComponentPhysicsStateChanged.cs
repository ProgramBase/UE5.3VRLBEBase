using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FComponentPhysicsStateChanged : FMulticastDelegate<Action<UPrimitiveComponent, EComponentPhysicsStateChange>>
	{
		public FComponentPhysicsStateChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FComponentPhysicsStateChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UPrimitiveComponent ChangedComponent, EComponentPhysicsStateChange StateChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ChangedComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)StateChange;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
