using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnPrimaryAssetLoaded : FMulticastDelegate<Action<UObject>>
	{
		public FOnPrimaryAssetLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnPrimaryAssetLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UObject Loaded)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Loaded?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
