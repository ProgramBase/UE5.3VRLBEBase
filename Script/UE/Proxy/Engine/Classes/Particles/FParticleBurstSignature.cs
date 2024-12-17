using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FParticleBurstSignature : FMulticastDelegate<Action<FName, float, int>>
	{
		public FParticleBurstSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FParticleBurstSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FName EventName, float EmitterTime, int ParticleCount)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = EventName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EmitterTime;

				*(int*)(__InBuffer + 12) = ParticleCount;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
