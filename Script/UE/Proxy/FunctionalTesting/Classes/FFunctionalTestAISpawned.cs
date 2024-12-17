using System;
using Script.CoreUObject;
using Script.Library;
using Script.AIModule;
using Script.Engine;

namespace Script.FunctionalTesting
{
	public class FFunctionalTestAISpawned : FMulticastDelegate<Action<AAIController, APawn>>
	{
		public FFunctionalTestAISpawned() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FFunctionalTestAISpawned() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AAIController Controller, APawn Pawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Pawn?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
