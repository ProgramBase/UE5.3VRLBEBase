using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	public class FOnListenerUnMountPak : FMulticastDelegate<Action<FString>>
	{
		public FOnListenerUnMountPak() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnListenerUnMountPak() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString PakName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PakName?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
