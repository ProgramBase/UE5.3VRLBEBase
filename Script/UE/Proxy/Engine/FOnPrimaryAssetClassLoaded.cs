using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnPrimaryAssetClassLoaded : FMulticastDelegate<Action<TSubclassOf<UObject>>>
	{
		public FOnPrimaryAssetClassLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnPrimaryAssetClassLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TSubclassOf<UObject> Loaded)
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
