using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	public class FOnEditNewActorsDropped : FMulticastDelegate<Action<TArray<UObject>, TArray<AActor>>>
	{
		public FOnEditNewActorsDropped() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnEditNewActorsDropped() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<UObject> DroppedObjects, TArray<AActor> DroppedActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DroppedObjects?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DroppedActors?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
