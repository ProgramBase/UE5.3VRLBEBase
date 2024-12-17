using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine.InterpToMovementComponent
{
	public class FOnInterpToResetDelegate : FMulticastDelegate<Action<FHitResult, float>>
	{
		public FOnInterpToResetDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnInterpToResetDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FHitResult ImpactResult, float Time)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ImpactResult?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
