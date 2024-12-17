using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnClusterUnionRemovedComponent : FMulticastDelegate<Action<UPrimitiveComponent>>
	{
		public FOnClusterUnionRemovedComponent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnClusterUnionRemovedComponent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UPrimitiveComponent Component)
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
