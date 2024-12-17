using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTasks
{
	public class FOnClaimedResourcesChangeSignature : FMulticastDelegate<Action<FGameplayResourceSet, FGameplayResourceSet>>
	{
		public FOnClaimedResourcesChangeSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnClaimedResourcesChangeSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FGameplayResourceSet NewlyClaimed, FGameplayResourceSet FreshlyReleased)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewlyClaimed?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FreshlyReleased?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
