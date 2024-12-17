using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FCharacterMovementUpdatedSignature : FMulticastDelegate<Action<float, FVector, FVector>>
	{
		public FCharacterMovementUpdatedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FCharacterMovementUpdatedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(float*)(__InBuffer) = DeltaSeconds;

				*(nint*)(__InBuffer + 4) = OldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = OldVelocity?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
