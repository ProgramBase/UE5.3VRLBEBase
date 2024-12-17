using System;
using Script.CoreUObject;
using Script.Library;
using Script.GeometryCollectionEngine;

namespace Script.GeometryCollectionEngine.GeometryCollectionComponent
{
	public class FNotifyGeometryCollectionPhysicsStateChange : FMulticastDelegate<Action<UGeometryCollectionComponent>>
	{
		public FNotifyGeometryCollectionPhysicsStateChange() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FNotifyGeometryCollectionPhysicsStateChange() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UGeometryCollectionComponent FracturedComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FracturedComponent?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
