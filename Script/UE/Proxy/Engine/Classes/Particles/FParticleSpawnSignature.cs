using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FParticleSpawnSignature : FMulticastDelegate<Action<FName, float, FVector, FVector>>
	{
		public FParticleSpawnSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FParticleSpawnSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FName EventName, float EmitterTime, FVector Location, FVector Velocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = EventName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EmitterTime;

				*(nint*)(__InBuffer + 12) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = Velocity?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
