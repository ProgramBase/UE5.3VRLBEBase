using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnCanvasRenderTargetUpdate : FMulticastDelegate<Action<UCanvas, int, int>>
	{
		public FOnCanvasRenderTargetUpdate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnCanvasRenderTargetUpdate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UCanvas Canvas, int Width, int Height)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Canvas?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Width;

				*(int*)(__InBuffer + 12) = Height;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
