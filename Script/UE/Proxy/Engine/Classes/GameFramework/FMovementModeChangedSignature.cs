using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FMovementModeChangedSignature : FMulticastDelegate<Action<ACharacter, EMovementMode, byte>>
	{
		public FMovementModeChangedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FMovementModeChangedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Character?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)PrevMovementMode;

				*(byte*)(__InBuffer + 9) = PreviousCustomMode;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
