using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UMG
{
	public class FDownloadImageDelegate : FMulticastDelegate<Action<UTexture2DDynamic>>
	{
		public FDownloadImageDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FDownloadImageDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UTexture2DDynamic Texture)
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
