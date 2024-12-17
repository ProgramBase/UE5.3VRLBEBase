using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnPrimaryAssetClassListLoaded : FMulticastDelegate<Action<TArray<TSubclassOf<UObject>>>>
	{
		public FOnPrimaryAssetClassListLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnPrimaryAssetClassListLoaded() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<TSubclassOf<UObject>> Loaded)
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
