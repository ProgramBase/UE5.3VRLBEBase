using System;
using Script.CoreUObject;
using Script.Library;
using Script.PhysicsCore;

namespace Script.Engine
{
	public class FParticleCollisionSignature : FMulticastDelegate<Action<FName, float, int, FVector, FVector, FVector, FVector, FName, UPhysicalMaterial>>
	{
		public FParticleCollisionSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FParticleCollisionSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FName EventName, float EmitterTime, int ParticleTime, FVector Location, FVector Velocity, FVector Direction, FVector Normal, FName BoneName, UPhysicalMaterial PhysMat)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[64];

				*(nint*)(__InBuffer) = EventName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EmitterTime;

				*(int*)(__InBuffer + 12) = ParticleTime;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Velocity?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Normal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 56) = PhysMat?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
