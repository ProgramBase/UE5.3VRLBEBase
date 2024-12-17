using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	public class FOnEditNewActorsPlaced : FMulticastDelegate<Action<UObject, TArray<AActor>>>
	{
		public FOnEditNewActorsPlaced() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnEditNewActorsPlaced() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UObject ObjToUse, TArray<AActor> PlacedActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ObjToUse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlacedActors?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
