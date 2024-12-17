using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	public class FOnListenerMountPak : FMulticastDelegate<Action<FPakMountInfo>>
	{
		public FOnListenerMountPak() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnListenerMountPak() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FPakMountInfo PakInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PakInfo?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
