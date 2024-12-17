using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Blutility
{
	public class FForEachActorIteratorSignature : FMulticastDelegate<Action<AActor, int>>
	{
		public FForEachActorIteratorSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FForEachActorIteratorSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor Actor, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
