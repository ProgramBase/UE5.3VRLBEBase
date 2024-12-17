using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine.ProjectileMovementComponent
{
	public class FOnProjectileBounceDelegate : FMulticastDelegate<Action<FHitResult, FVector>>
	{
		public FOnProjectileBounceDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnProjectileBounceDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FHitResult ImpactResult, FVector ImpactVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ImpactResult?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ImpactVelocity?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
