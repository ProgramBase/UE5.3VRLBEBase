using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnMontageStartedMCDelegate : FMulticastDelegate<Action<UAnimMontage>>
	{
		public FOnMontageStartedMCDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMontageStartedMCDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UAnimMontage Montage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
