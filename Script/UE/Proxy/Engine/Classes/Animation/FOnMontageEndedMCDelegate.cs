using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnMontageEndedMCDelegate : FMulticastDelegate<Action<UAnimMontage, bool>>
	{
		public FOnMontageEndedMCDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMontageEndedMCDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
