using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	public class FActorPerceptionUpdatedDelegate : FMulticastDelegate<Action<AActor, FAIStimulus>>
	{
		public FActorPerceptionUpdatedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorPerceptionUpdatedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor Actor, FAIStimulus Stimulus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Stimulus?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
