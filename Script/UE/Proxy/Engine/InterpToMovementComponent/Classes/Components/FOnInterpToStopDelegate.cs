using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine.InterpToMovementComponent
{
	public class FOnInterpToStopDelegate : FMulticastDelegate<Action<FHitResult, float>>
	{
		public FOnInterpToStopDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnInterpToStopDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
