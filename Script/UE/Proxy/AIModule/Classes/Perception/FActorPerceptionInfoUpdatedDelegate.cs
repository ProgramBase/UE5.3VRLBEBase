using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	public class FActorPerceptionInfoUpdatedDelegate : FMulticastDelegate<Action<FActorPerceptionUpdateInfo>>
	{
		public FActorPerceptionInfoUpdatedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FActorPerceptionInfoUpdatedDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FActorPerceptionUpdateInfo UpdateInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UpdateInfo?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
