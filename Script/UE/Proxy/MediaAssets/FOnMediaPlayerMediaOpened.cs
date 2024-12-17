using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	public class FOnMediaPlayerMediaOpened : FMulticastDelegate<Action<FString>>
	{
		public FOnMediaPlayerMediaOpened() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMediaPlayerMediaOpened() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString OpenedUrl)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OpenedUrl?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
