using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	public class FOnMediaPlayerMediaOpenFailed : FMulticastDelegate<Action<FString>>
	{
		public FOnMediaPlayerMediaOpenFailed() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMediaPlayerMediaOpenFailed() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString FailedUrl)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FailedUrl?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
