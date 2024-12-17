using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnClusterUnionBoundsChanged : FMulticastDelegate<Action<UClusterUnionComponent, FBoxSphereBounds>>
	{
		public FOnClusterUnionBoundsChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnClusterUnionBoundsChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UClusterUnionComponent Component, FBoxSphereBounds Bounds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Bounds?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
