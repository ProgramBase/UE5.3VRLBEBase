using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Blutility
{
	public class FOnAsyncCaptureSceneComplete : FMulticastDelegate<Action<UTextureRenderTarget2D>>
	{
		public FOnAsyncCaptureSceneComplete() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAsyncCaptureSceneComplete() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UTextureRenderTarget2D Texture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
