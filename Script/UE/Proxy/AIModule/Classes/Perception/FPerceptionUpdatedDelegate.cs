using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	public class FPerceptionUpdatedDelegate : FMulticastDelegate<Action<TArray<AActor>>>
	{
		public FPerceptionUpdatedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPerceptionUpdatedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<AActor> UpdatedActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UpdatedActors?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
