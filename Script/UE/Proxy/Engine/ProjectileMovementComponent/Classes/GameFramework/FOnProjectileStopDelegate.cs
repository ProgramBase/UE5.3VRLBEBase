using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine.ProjectileMovementComponent
{
	public class FOnProjectileStopDelegate : FMulticastDelegate<Action<FHitResult>>
	{
		public FOnProjectileStopDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnProjectileStopDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FHitResult ImpactResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ImpactResult?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
