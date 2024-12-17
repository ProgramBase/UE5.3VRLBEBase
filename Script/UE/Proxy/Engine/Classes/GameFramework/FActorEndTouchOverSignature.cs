using System;
using Script.CoreUObject;
using Script.Library;
using Script.InputCore;

namespace Script.Engine
{
	public class FActorEndTouchOverSignature : FMulticastDelegate<Action<ETouchIndex, AActor>>
	{
		public FActorEndTouchOverSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorEndTouchOverSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(ETouchIndex FingerIndex, AActor TouchedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)FingerIndex;

				*(nint*)(__InBuffer + 1) = TouchedActor?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
