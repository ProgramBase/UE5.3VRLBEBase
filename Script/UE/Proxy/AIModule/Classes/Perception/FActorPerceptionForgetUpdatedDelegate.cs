using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	public class FActorPerceptionForgetUpdatedDelegate : FMulticastDelegate<Action<AActor>>
	{
		public FActorPerceptionForgetUpdatedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorPerceptionForgetUpdatedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
