using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine.InterpToMovementComponent
{
	public class FOnInterpToWaitBeginDelegate : FMulticastDelegate<Action<FHitResult, float>>
	{
		public FOnInterpToWaitBeginDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnInterpToWaitBeginDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
