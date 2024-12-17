using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FParticleDeathSignature : FMulticastDelegate<Action<FName, float, int, FVector, FVector, FVector>>
	{
		public FParticleDeathSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FParticleDeathSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FName EventName, float EmitterTime, int ParticleTime, FVector Location, FVector Velocity, FVector Direction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = EventName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EmitterTime;

				*(int*)(__InBuffer + 12) = ParticleTime;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Velocity?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
