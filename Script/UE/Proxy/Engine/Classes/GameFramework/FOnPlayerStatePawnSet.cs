using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnPlayerStatePawnSet : FMulticastDelegate<Action<APlayerState, APawn, APawn>>
	{
		public FOnPlayerStatePawnSet() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnPlayerStatePawnSet() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(APlayerState Player, APawn NewPawn, APawn OldPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewPawn?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OldPawn?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
