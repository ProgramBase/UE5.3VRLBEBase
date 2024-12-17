using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnMontageBlendingOutStartedMCDelegate : FMulticastDelegate<Action<UAnimMontage, bool>>
	{
		public FOnMontageBlendingOutStartedMCDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMontageBlendingOutStartedMCDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UAnimMontage Montage, bool bInterrupted)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInterrupted;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
