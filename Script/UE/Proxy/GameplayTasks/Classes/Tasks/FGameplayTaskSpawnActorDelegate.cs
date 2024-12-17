using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GameplayTasks
{
	public class FGameplayTaskSpawnActorDelegate : FMulticastDelegate<Action<AActor>>
	{
		public FGameplayTaskSpawnActorDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FGameplayTaskSpawnActorDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor SpawnedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpawnedActor?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
